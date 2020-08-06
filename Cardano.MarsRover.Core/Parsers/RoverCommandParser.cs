using Cardano.MarsRover.Core.Commands;
using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core
{
    public static class RoverCommandParser
    {
        private static Dictionary<Char, ICommand> RoverCommands
        {
            get
            {
                var commands = new Dictionary<Char, ICommand>
                {
                    {'L', new TurnLeftCommand() },
                    {'R', new TurnRightCommand() },
                    {'M', new MoveCommand() }
                };
                return commands;
            }
        }

        public static List<ICommand> ParseRoverCommands(string commandString)
        {
            List<ICommand> commands = new List<ICommand>();
            foreach(var c in commandString)
            {
                ICommand command = RoverCommands[c];
                commands.Add(command);
            }
            return commands;
        }
    }
}
