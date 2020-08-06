using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core.Directions
{
    public interface IDirection
    {
        Coordinates MoveForward(Coordinates currentCoordinates);
        IDirection TurnLeft();
        IDirection TurnRight();

    }
}
