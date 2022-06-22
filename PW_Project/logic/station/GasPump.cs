using System;
using System.Drawing;
using System.Windows.Forms;

namespace PW_Project.logic.station
{
    enum BoxOrientationVertical
    {
        FRONT, BACK
    }
    enum BoxOrientationHorizontal
    {
        LEFT, RIGHT
    }

    class GasPump
    {
        private bool free;
        private Vehicle servedVehicle;
        private readonly Point box;
        private readonly BoxOrientationHorizontal horizontalOrientation;
        private readonly BoxOrientationVertical verticalOrientation;
        

        public GasPump(int i, BoxOrientationHorizontal horizontal)
        {
            free = true;
            servedVehicle = null;
            horizontalOrientation = horizontal;

            if (i % 2 == 0)
            {
                box = new Point(MainForm.gasPumps[i / 2].Location.X, 
                    MainForm.gasPumps[i / 2].Location.Y);
            }
            else
            {
                box = new Point(MainForm.gasPumps[i / 2].Location.X,
                    MainForm.gasPumps[i / 2].Location.Y);
            }

            if(horizontalOrientation == BoxOrientationHorizontal.LEFT)
            {
                box.X -= 18;
            }
            else
            {
                box.X += 20;
            }

            if (i == 2 || i == 3 || i == 6 || i == 7 ||
                i == 10 || i == 11 || i == 14 || i == 15)
            {
                verticalOrientation = BoxOrientationVertical.FRONT;
            }
            else
            {
                verticalOrientation = BoxOrientationVertical.BACK;
            }
        }

        public bool Free { get => free; set => free = value; }
        internal Vehicle ServedVehicle { get => servedVehicle; set => servedVehicle = value; }
        public Point Box { get => box; }

        internal BoxOrientationVertical VerticalOrientation => verticalOrientation;
        internal BoxOrientationHorizontal HorizontalOrientation => horizontalOrientation;
    }
}
