using Cardano.MarsRover.Core.Commands;
using Cardano.MarsRover.Core.Directions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core
{
    public class MarsRover
    {
        private Plateau plateau;
        public Coordinates CurrentCoordinates { get; private set; }
        public IDirection CurrentDirection { get; private set; }

        public MarsRover(Plateau plateau, Coordinates coordinates, IDirection direction)
        {
            this.plateau = plateau;
            CurrentCoordinates = coordinates;
            CurrentDirection = direction;
        }

        public void ExecuteCommands(string stringCommand)
        {
            List<ICommand> roverCommands = RoverCommandParser.ParseRoverCommands(stringCommand);
            foreach(ICommand command in roverCommands)
            {
                command.Execute(this);
            }
        }
        public void TurnLeft()
        {
            CurrentDirection = CurrentDirection.TurnLeft();
        }

        public void TurnRight()
        {
            CurrentDirection = CurrentDirection.TurnRight();
        }

        public void Move()
        {
            var newCoordinates = CurrentDirection.MoveForward(CurrentCoordinates);
            if (!plateau.IsOutsidePlateau(newCoordinates))
                CurrentCoordinates = newCoordinates;
        }
    }
}
