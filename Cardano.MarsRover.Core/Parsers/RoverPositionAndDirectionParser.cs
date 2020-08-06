using Cardano.MarsRover.Core.Direction;
using Cardano.MarsRover.Core.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cardano.MarsRover.Core.Parsers
{
    public static class RoverPositionAndDirectionParser
    {
        private static Dictionary<Char, IDirection> Directions
        {
            get
            {
                var directions = new Dictionary<Char, IDirection>
                {
                    {'E', new East() },
                    {'W', new West() },
                    {'N', new North() },
                    {'S', new South() }
                };
                return directions;
            }
        }
        public static dynamic ParseRoverPositionAndDirection(string positionAndDirection)
        {
            var positionAndDirectionArray = positionAndDirection.Split(' ');

            if (positionAndDirectionArray.Length != 3)
                throw new ArgumentNullException("Cannot parse rover position and dimenstion");

            int xCoordinate = Int32.Parse(positionAndDirectionArray[0]);
            int yCoordinate = Int32.Parse(positionAndDirectionArray[1]);

            Coordinates roverPosition = new Coordinates(xCoordinate, yCoordinate);

            IDirection roverDirection = Directions[positionAndDirectionArray[2].First()];
            return new { Position = roverPosition, Direction = roverDirection };
        }
    }
}
