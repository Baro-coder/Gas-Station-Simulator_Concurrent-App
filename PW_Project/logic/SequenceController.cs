using System;
using System.Drawing;
using System.Threading;

using PW_Project.logic.station;

namespace PW_Project.logic
{
    static class SequenceController
    {
        //
        // ROUTE POINTS
        //
        public static Point EntryPoint;
        public static Point[] QueuePoints;
        public static Point[] ExitRoutePoints;

        static SequenceController()
        {
            EntryPoint = new Point(65, 5);
            
            QueuePoints = new Point[3];
            QueuePoints[0] = new Point(EntryPoint.X, EntryPoint.Y + 40);
            for (int i = 1; i < QueuePoints.Length; i++)
            {
                QueuePoints[i] = new Point(QueuePoints[i-1].X, QueuePoints[i-1].Y + 40);
            }

            ExitRoutePoints = new Point[3];
            ExitRoutePoints[0] = new Point(500, 285);
            ExitRoutePoints[1] = new Point(500, 400);
            ExitRoutePoints[2] = new Point(700, 400);
        }

        //
        // MAIN SEQUENCE
        //
        public static void ThreadMainSequence()
        {
            Vehicle vehicle = new Vehicle();
            
            vehicle = EnterTheStation(vehicle);
            vehicle = ApproachTheGasPump(vehicle);
            vehicle = Refuel(vehicle);
            Pay(vehicle);
            vehicle = ExitTheGasPump(vehicle);
            ExitTheStation(vehicle);
        }

        //
        // AUXILLARY SEQUENCES
        //
        private static Vehicle EnterTheStation(Vehicle vehicle)
        {
            Monitor.Enter(ThreadController.Entrance);
            try
            {
                vehicle.Spawn();
                ThreadController.SEM_StationQueue[0].WaitOne();
            }
            finally
            {
                vehicle.MoveTo(QueuePoints[0]);
                Monitor.Exit(ThreadController.Entrance);
            }
            return vehicle;
        }

        private static Vehicle ApproachTheGasPump(Vehicle vehicle)
        {
            for(int i = 1; i < QueuePoints.Length; i++)
            {
                ThreadController.SEM_StationQueue[i].WaitOne();
                ThreadController.SEM_StationQueue[i - 1].Release();
                vehicle.MoveTo(QueuePoints[i]);
            }

            Monitor.Enter(ThreadController.GasBox);
            try
            {
                ThreadController.SEM_GasBoxes.WaitOne();
                while(vehicle.GasPumpIndex == -1)
                {
                    vehicle.GasPumpIndex = GasStation.GetGasPumpBoxIndexAndTakeBox(vehicle);
                }
            }
            finally
            {
                Monitor.Exit(ThreadController.GasBox);
            }

            ThreadController.SEM_StationQueue[QueuePoints.Length - 1].Release();
            GasPump serviceBox = GasStation.GetTheBox(vehicle.GasPumpIndex);

            if(serviceBox.VerticalOrientation == BoxOrientationVertical.FRONT)
            {
                if(serviceBox.HorizontalOrientation == BoxOrientationHorizontal.LEFT)
                {
                    vehicle.MoveTo(new Point(serviceBox.Box.X - 18, serviceBox.Box.Y));
                    vehicle.MoveTo(serviceBox.Box);
                    vehicle.TurnRight();
                }
                else if(serviceBox.HorizontalOrientation == BoxOrientationHorizontal.RIGHT)
                {
                    vehicle.MoveTo(new Point(serviceBox.Box.X + 20, serviceBox.Box.Y));
                    vehicle.MoveTo(serviceBox.Box);
                    vehicle.TurnLeft();
                }
            }
            else
            {
                vehicle.MoveTo(serviceBox.Box);
            }

            return vehicle;
        }

        private static Vehicle Refuel(Vehicle vehicle)
        {
            Thread.Sleep(new Random().Next(5, 15) * 1000);
            vehicle.BlinkYellow();
            return vehicle;
        }

        private static void Pay(Vehicle vehicle)
        {
            GasStation.JoinTheQueueAndPay(vehicle);
            vehicle.BlinkGreen();
        }

        private static Vehicle ExitTheGasPump(Vehicle vehicle)
        {
            Monitor.Enter(ThreadController.GasExit);
            try
            {
                GasStation.ReleaseGasPumpBox(vehicle.GasPumpIndex);

                GasPump serviceBox = GasStation.GetTheBox(vehicle.GasPumpIndex);
                if (serviceBox.VerticalOrientation == BoxOrientationVertical.BACK)
                {
                    if (serviceBox.HorizontalOrientation == BoxOrientationHorizontal.LEFT)
                    {
                        vehicle.MoveTo(new Point(vehicle.Car.Location.X - 18, vehicle.Car.Location.Y));
                    }
                    else if (serviceBox.HorizontalOrientation == BoxOrientationHorizontal.RIGHT)
                    {
                        vehicle.MoveTo(new Point(vehicle.Car.Location.X + 20, vehicle.Car.Location.Y));
                    }

                    vehicle.MoveTo(new Point(vehicle.Car.Location.X, vehicle.Car.Location.Y + 105));
                }
                else if (serviceBox.VerticalOrientation == BoxOrientationVertical.FRONT)
                {
                    vehicle.MoveTo(new Point(vehicle.Car.Location.X, vehicle.Car.Location.Y + 60));
                }
            }
            finally
            {
                ThreadController.SEM_GasBoxes.Release();
            }

            return vehicle;
        }

        private static void ExitTheStation(Vehicle vehicle)
        {
            vehicle.MoveTo(ExitRoutePoints[0]);
            
            Monitor.Enter(ThreadController.Exit);
            try
            {
                Monitor.Exit(ThreadController.GasExit);
                vehicle.MoveTo(ExitRoutePoints[1]);
            }
            finally
            {
                Monitor.Exit(ThreadController.Exit);
                vehicle.MoveTo(ExitRoutePoints[2]);
                vehicle.Remove();
            }
        }
    }
}
