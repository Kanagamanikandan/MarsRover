﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core.Commands
{
    public class TurnLeftCommand : ICommand
    {
        public void Execute(MarsRover rover)
        {
            rover.TurnLeft();
        }
    }
}
