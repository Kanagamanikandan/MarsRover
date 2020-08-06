using Cardano.MarsRover.Core.Directions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core.Direction
{
    public class West : IDirection
    {
        public Coordinates MoveForward(Coordinates currentCoordinates)
        {
            return new Coordinates(currentCoordinates.XCoordinate - 1, currentCoordinates.YCoordinate);
        }

        public IDirection TurnLeft()
        {
            return new South();
        }

        public IDirection TurnRight()
        {
            return new North();
        }

        public override string ToString()
        {
            return "W";
        }
    }
}
