using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover
{
    public class Rover
    {
        public int X { get; private set; }
        public int Y { get; private set; }

        public Rover(int initX, int initY)
        {
            X = initX;
            Y = initY;
        }


    }
}
