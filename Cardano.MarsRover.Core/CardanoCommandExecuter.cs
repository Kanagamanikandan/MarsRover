using Cardano.MarsRover.Core.Parsers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Cardano.MarsRover.Core
{
    public class CardanoCommandExecuter
    {
        private const char newLineDelimiter = '\n';
        private readonly string cardonoCommand;

        public CardanoCommandExecuter(string cardonoCommand)
        {
            this.cardonoCommand = cardonoCommand;
        }

        public void ParseAndExecuteCommands()
        {
            string[] inputByLines = cardonoCommand.Split(newLineDelimiter);

            if(inputByLines.Length % 2 == 0)
            {
                throw new InvalidEnumArgumentException("Unexpected number of lines in the cardano command");
            }

            Coordinates plateauUpperRightCoordinate = PlateauParser.ParsePlateauDimenstion(inputByLines[0]);
            Plateau plateau = new Plateau(plateauUpperRightCoordinate);

            int lineIndex = 1;
            while(inputByLines.Length > lineIndex)
            {
                var roverPositionAndDirection = RoverPositionAndDirectionParser
                    .ParseRoverPositionAndDirection(inputByLines[lineIndex]);
                
                MarsRover rover = new MarsRover(plateau,
                    roverPositionAndDirection.Position,
                    roverPositionAndDirection.Direction);
                lineIndex++;

                rover.ExecuteCommands(inputByLines[lineIndex]);
                lineIndex++;
                Console.WriteLine($"{rover.CurrentCoordinates.XCoordinate} {rover.CurrentCoordinates.YCoordinate} " +
                    $"{rover.CurrentDirection.ToString()}");

            }
        }
    }
}
