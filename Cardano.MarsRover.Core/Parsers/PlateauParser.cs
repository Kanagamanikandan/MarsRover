using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core.Parsers
{
    public static class PlateauParser
    {
        public static Coordinates ParsePlateauDimenstion(string dimension)
        {
            var plateauDimensions = dimension.Split(' ');
            
            if (plateauDimensions.Length != 2)
                throw new ArgumentNullException("Invalid plateau dimenstions");

            int xCoordinate = Int32.Parse(plateauDimensions[0]);
            int yCoordinate = Int32.Parse(plateauDimensions[1]);

            Coordinates coordinates = new Coordinates(xCoordinate, yCoordinate);
            return coordinates;
        }
    }
}
