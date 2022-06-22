using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;

namespace PW_Project.logic
{
    enum CarColor
    {
        RED,
        YELLOW,
        GREEN
    }

    class Vehicle
    {
        private readonly PictureBox car;

        private int orientation;  // 1 - up | 2 - left | 3 - down | 4 - right
        private int gasPumpIndex;
        public PictureBox Car { get => car; }
        public int GasPumpIndex { get => gasPumpIndex; set => gasPumpIndex = value; }


        public Vehicle()
        {
            orientation = 1;
            gasPumpIndex = -1;

            car = new PictureBox
            {
                Image = Properties.Resources.red_car,
                Width = 18,
                Height = 30,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Location = SequenceController.EntryPoint,
                BackColor = Color.Transparent
            };
        }

        //
        // PUBLIC OPS
        //
        public void Spawn()
        {
            MainForm.preview.Invoke(new Action(delegate ()
            {
                MainForm.preview.Controls.Add(car);
            }));
            TurnLeft();
            TurnLeft();
        }

        public void Remove()
        {
            MainForm.preview.Invoke(new Action(delegate ()
            {
                MainForm.preview.Controls.Remove(car);
            }));
        }

        public void MoveTo(Point dest)
        {
            int steps = 0;
            int direction = 0;

            //
            // VERTICAL MOVEMENT
            //
            if (car.Location.X == dest.X && car.Location.Y != dest.Y)
            {
                if (car.Location.Y > dest.Y)
                {
                    steps = (car.Location.Y - dest.Y) / 5;
                    direction = 1;
                }
                else
                {
                    steps = (dest.Y - car.Location.Y) / 5;
                    direction = 3;
                }
            }
            //
            // HORIZONTAL MOVEMENT
            //
            else if (car.Location.X != dest.X && car.Location.Y == dest.Y)
            {
                if (car.Location.X > dest.X)
                {
                    steps = (car.Location.X - dest.X) / 5;
                    direction = 2;
                }
                else
                {
                    steps = (dest.X - car.Location.X) / 5;
                    direction = 4;
                }
            }
            //
            // VERTICAL AND HORIZONTAL MOVEMENT
            //
            else if (car.Location.X != dest.X && car.Location.Y != dest.Y)
            {
                MoveTo(new Point(dest.X, car.Location.Y));
                MoveTo(dest);
                return;
            }

            //
            // TURN LEFT / RIGHT
            //
            if (direction == orientation + 1 || direction == orientation - 3)
            {
                TurnLeft();
            }
            if (direction == orientation - 1 || direction == orientation + 3)
            {
                TurnRight();
            }

            //
            // MOVEMENT ANIMATION
            //
            if (direction == orientation)
            {
                for (int i = 0; i < steps; i++)
                {
                    MoveForward();
                }

                if(orientation == 1 || orientation == 3)
                {
                    car.Invoke(new Action(delegate ()
                    {
                        car.Location = new Point(car.Location.X, dest.Y);
                    }));
                }
                else if(orientation == 2 || orientation == 4)
                {
                    car.Invoke(new Action(delegate ()
                    {
                        car.Location = new Point(dest.X, car.Location.Y);
                    }));
                }
            }
        }

        public void BlinkYellow()
        {
            for(int i = 0; i < 5; i++)
            {
                if(i % 2 == 0)
                {
                    TurnColor(CarColor.YELLOW);
                }
                else
                {
                    TurnColor(CarColor.RED);
                }
                Thread.Sleep(100);
            }
        }

        public void BlinkGreen()
        {
            for (int i = 0; i < 5; i++)
            {
                if (i % 2 == 0)
                {
                    TurnColor(CarColor.GREEN);
                }
                else
                {
                    TurnColor(CarColor.YELLOW);
                }
                Thread.Sleep(100);
            }
        }

        public void TurnLeft()
        {
            car.Invoke(new Action(delegate ()
            {
                car.Image.RotateFlip(RotateFlipType.Rotate90FlipXY);
                int tmp = car.Width;
                car.Width = car.Height;
                car.Height = tmp;
            }));

            orientation++;
            if (orientation == 5)
            {
                orientation = 1;
            }
        }

        public void TurnRight()
        {
            car.Invoke(new Action(delegate ()
            {
                car.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                int tmp = car.Width;
                car.Width = car.Height;
                car.Height = tmp;
            }));

            orientation--;
            if (orientation == 0)
            {
                orientation = 4;
            }
        }

        //
        // MOVEMENT
        //
        private void MoveForward()
        {
            Point newLocation = new Point(car.Location.X, car.Location.Y);
            if (orientation == 1)
            {
                newLocation.Y -= 5;
            }
            else if (orientation == 2)
            {
                newLocation.X -= 5;
            }
            else if (orientation == 3)
            {
                newLocation.Y += 5;
            }
            else if (orientation == 4)
            {
                newLocation.X += 5;
            }

            car.Invoke(new Action(delegate ()
            {
                car.Location = newLocation;
            }));

            Thread.Sleep(10);
        }

        //
        // COLOR
        //
        private void TurnColor(CarColor color)
        {
            car.Invoke(new Action(delegate ()
            {
                if(color == CarColor.RED)
                {
                    car.Image = Properties.Resources.red_car;
                }
                else if(color == CarColor.YELLOW)
                {
                    car.Image = Properties.Resources.yellow_car;
                }
                else if(color == CarColor.GREEN)
                {
                    car.Image = Properties.Resources.green_car;
                }
                car.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
            }));
        }
    }
}
