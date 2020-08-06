using Cardano.MarsRover.Core.Directions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core.Direction
{
    public class South : IDirection
    {
        
        public Coordinates MoveForward(Coordinates currentCoordinates)
        {
            return new Coordinates(currentCoordinates.XCoordinate, currentCoordinates.YCoordinate - 1);
        }

        public IDirection TurnLeft()
        {
            return new East();
        }

        public IDirection TurnRight()
        {
            return new West();
        }

        public override string ToString()
        {
            return "S";
        }
    }
}
