using System;
using System.Drawing;

namespace PW_Project.logic.station
{
    static class GasStation
    {
        private static readonly GasPump[] gasPumps;
        private static readonly CashRegister[] cashRegisters;

        internal static CashRegister[] CashRegisters => cashRegisters;

        static GasStation()
        {
            gasPumps = new GasPump[16];
            cashRegisters = new CashRegister[4];

            for (int i = 0; i < gasPumps.Length; i++)
            {
                if (i % 2 == 0)
                {
                    gasPumps[i] = new GasPump(i, BoxOrientationHorizontal.LEFT);
                }
                else
                {
                    gasPumps[i] = new GasPump(i, BoxOrientationHorizontal.RIGHT);
                }
            }

            for (int i = 0; i < cashRegisters.Length; i++)
            {
                cashRegisters[i] = new CashRegister();
            }
        }

        //
        // GAS BOXES
        // LOCATE AND TAKE FIRST FREE BOX
        //
        public static int GetGasPumpBoxIndexAndTakeBox(Vehicle vehicle)
        {
            int ind = GetFirstFreeGasPumpIndex();

            if (ind != -1)
            {
                if (ind <= 13 && gasPumps[ind + 2].Free)
                {
                    gasPumps[ind + 2].Free = false;
                    gasPumps[ind + 2].ServedVehicle = vehicle;
                    return ind + 2;
                }
                else
                {
                    gasPumps[ind].Free = false;
                    gasPumps[ind].ServedVehicle = vehicle;
                    return ind;
                }
            }
            return -1;
        }

        private static int GetFirstFreeGasPumpIndex()
        {
            for (int i = 0; i < gasPumps.Length; i++)
            {
                if (gasPumps[i].Free)
                {
                    return i;
                }
            }

            return -1;
        }

        //
        // RELEASE TAKEN BOX
        //
        public static void ReleaseGasPumpBox(int ind)
        {
            gasPumps[ind].Free = true;
            gasPumps[ind].ServedVehicle = null;
        }
    
        //
        // GET THE BOX
        //
        public static GasPump GetTheBox(int ind)
        {
            return gasPumps[ind];
        }

        //
        // CASHES
        // JOINT THE SHORTEST QUEUE AND PAY
        //
        public static void JoinTheQueueAndPay(Vehicle vehicle)
        {
            int min = cashRegisters[0].Queue.Count;
            int cashId = 0;

            for(int i = 0; i < cashRegisters.Length; i++)
            {
                int act = cashRegisters[i].Queue.Count;
                if (act < min)
                {
                    min = cashRegisters[i].Queue.Count;
                    cashId = i;
                }
            }

            cashRegisters[cashId].EnterTheQueue(vehicle);
        }
    }
}
