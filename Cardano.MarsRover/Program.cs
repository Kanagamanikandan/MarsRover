using System;
using Cardano.MarsRover.Core;
namespace Cardano.MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardanoCommand = "5 5\n1 2 N\nLML\n3 3 E\nMMR";
            CardanoCommandExecuter cardanoCommandExecuter = new CardanoCommandExecuter(cardanoCommand);
            cardanoCommandExecuter.ParseAndExecuteCommands();
            Console.ReadLine();
        }
    }
}
