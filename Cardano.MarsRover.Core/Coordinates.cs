using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core
{
    public class Coordinates
    {
        public Coordinates(int xCoordinate, int yCoordinate)
        {
            XCoordinate = xCoordinate;
            YCoordinate = yCoordinate;
        }

        public int XCoordinate { get; }
        public int YCoordinate { get; }
    }
}
