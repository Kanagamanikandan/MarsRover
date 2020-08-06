
namespace Cardano.MarsRover.Tests
{
    using Cardano.MarsRover.Core;
    using Cardano.MarsRover.Core.Direction;
    using Cardano.MarsRover.Core.Directions;
    using NUnit.Framework;
    
    [TestFixture]
    public class MarsRoverTests
    {
        private Plateau plateau;
        [SetUp]
        public void Setup()
        {
            plateau = new Plateau(new Coordinates(5, 5));
        }


        [Test]
        public void When_Rover_Is_Positioned_At_North_It_Should_Remain_The_Same()
        {
            IDirection direction = new North();
            Coordinates initialPosition = new Coordinates(1, 2);
            MarsRover rover = new MarsRover(plateau, initialPosition, direction);
            Assert.That(rover.CurrentDirection, Is.TypeOf<North>());
        }

        [Test]
        public void When_Rover_Is_Positioned_At_North_And_Turned_Left_The_Direction_Is_West()
        {
            IDirection direction = new North();
            Coordinates initialPosition = new Coordinates(1, 2);
            MarsRover rover = new MarsRover(plateau, initialPosition, direction);
            rover.ExecuteCommands("L");
            Assert.That(rover.CurrentDirection, Is.TypeOf<West>());
        }

        [Test]
        public void When_Rover_Is_Positioned_At_1_1_N_And_Move_Rover_Will_Be_At_1_2()
        {
            IDirection direction = new North();
            Coordinates initialPosition = new Coordinates(1, 1);
            MarsRover rover = new MarsRover(plateau, initialPosition, direction);
            rover.ExecuteCommands("M");
            Assert.That(rover.CurrentCoordinates.XCoordinate, Is.EqualTo(1));
            Assert.That(rover.CurrentCoordinates.YCoordinate, Is.EqualTo(2));
        }


        [Test]
        public void When_Rover_Is_Positioned_At_1_1_N_And_Move_Left_Move_Left_Then_Rover_Will_Be_At_0_2_South()
        {
            IDirection direction = new North();
            Coordinates initialPosition = new Coordinates(1, 1);
            MarsRover rover = new MarsRover(plateau, initialPosition, direction);
            rover.ExecuteCommands("MLML");
            Assert.That(rover.CurrentCoordinates.XCoordinate, Is.EqualTo(0));
            Assert.That(rover.CurrentCoordinates.YCoordinate, Is.EqualTo(2));
            Assert.That(rover.CurrentDirection, Is.TypeOf<South>());
        }

        [Test]
        public void When_Moving_North_At_Y_Border_Should_Not_Go_Outside_Plateau()
        {
            IDirection direction = new North();
            Coordinates initialPosition = new Coordinates(0, 5);
            MarsRover rover = new MarsRover(plateau, initialPosition, direction);
            rover.ExecuteCommands("MMMMM");
            Assert.That(rover.CurrentCoordinates.XCoordinate, Is.EqualTo(0));
            Assert.That(rover.CurrentCoordinates.YCoordinate, Is.EqualTo(5));
        }

        [Test]
        public void When_Moving_East_At_X_Border_Should_Not_Go_Outside_Plateau()
        {
            IDirection direction = new East();
            Coordinates initialPosition = new Coordinates(5, 2);
            MarsRover rover = new MarsRover(plateau, initialPosition, direction);
            rover.ExecuteCommands("MMMMM");
            Assert.That(rover.CurrentCoordinates.XCoordinate, Is.EqualTo(5));
            Assert.That(rover.CurrentCoordinates.YCoordinate, Is.EqualTo(2));
        }
    }
}