using Cardano.MarsRover.Core.Directions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core.Direction
{
    public class East : IDirection
    {
        public Coordinates MoveForward(Coordinates currentCoordinates)
        {
            return new Coordinates(currentCoordinates.XCoordinate + 1, currentCoordinates.YCoordinate);
        }

        public IDirection TurnLeft()
        {
            return new North();
        }

        public IDirection TurnRight()
        {
            return new South();
        }

        public override string ToString()
        {
            return "E";
        }
    }
}
