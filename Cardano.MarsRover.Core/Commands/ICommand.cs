using System;
using System.Collections.Generic;
using System.Text;

namespace Cardano.MarsRover.Core.Commands
{
    public interface ICommand
    {
        void Execute(MarsRover rover);
    }
}
