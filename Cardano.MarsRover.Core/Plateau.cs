using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core
{
    public class Plateau
    {
        private readonly Coordinates lowerLeftCoordinates = new Coordinates(0, 0);
        private readonly Coordinates upperRightCoordinates;
        
        public Plateau(Coordinates upperRightYCoordinates)
        {
            this.upperRightCoordinates = upperRightYCoordinates;
        }

        public bool IsOutsidePlateau(Coordinates coordinates)
        {
            return coordinates.XCoordinate < lowerLeftCoordinates.XCoordinate
                || coordinates.YCoordinate < lowerLeftCoordinates.YCoordinate
                || coordinates.XCoordinate > upperRightCoordinates.XCoordinate
                || coordinates.YCoordinate > upperRightCoordinates.YCoordinate;
        }

    }
}
