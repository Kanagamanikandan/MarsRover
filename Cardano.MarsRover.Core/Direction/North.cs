using Cardano.MarsRover.Core.Directions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core.Direction
{
    public class North : IDirection
    {
        
        public Coordinates MoveForward(Coordinates currentCoordinates)
        {
            return new Coordinates(currentCoordinates.XCoordinate, currentCoordinates.YCoordinate + 1);
        }

        public IDirection TurnLeft()
        {
            return new West();
        }

        public IDirection TurnRight()
        {
            return new East();
        }

        public override string ToString()
        {
            return "N";
        }
    }
}
