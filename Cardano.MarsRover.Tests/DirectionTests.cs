
namespace Cardano.MarsRover.Tests
{
    using Cardano.MarsRover.Core;
    using Cardano.MarsRover.Core.Direction;
    using Cardano.MarsRover.Core.Directions;
    using NUnit.Framework;
    using System;
    using System.Collections.Generic;
    using System.Text;

    [TestFixture]
    public class DirectionTests
    {
        private Plateau plateau;
        [SetUp]
        public void Setup()
        {
            plateau = new Plateau(new Coordinates(5, 5));
        }
        [Test]
        public void When_East_And_Turn_Right_Direction_Should_Be_South()
        {
            var direction = new East();
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<South>());
        }

        [Test]
        public void When_South_And_Turn_Left_Direction_Should_Be_East()
        {
            var direction = new South();
            var newdirection = direction.TurnLeft();
            Assert.That(newdirection, Is.TypeOf<East>());
        }

        [Test]
        public void When_South_And_Turn_Right_Direction_Should_Be_West()
        {
            var direction = new South();
            var newdirection = direction.TurnRight();
            Assert.That(newdirection, Is.TypeOf<West>());
        }

        [Test]
        public void When_Rover_At_1_2_South_And_Move_Should_Be_1_1()
        {
            var direction = new South();
            var newCoordinates = direction.MoveForward(new Coordinates(1,2));
            Assert.That(newCoordinates.XCoordinate, Is.EqualTo(1));
            Assert.That(newCoordinates.YCoordinate, Is.EqualTo(1));
        }


        [Test]
        public void When_Rover_At_3_2_North_And_Move_Should_Be_3_3()
        {
            var direction = new North();
            var newCoordinates = direction.MoveForward(new Coordinates(3, 2));
            Assert.That(newCoordinates.XCoordinate, Is.EqualTo(3));
            Assert.That(newCoordinates.YCoordinate, Is.EqualTo(3));
        }

        [Test]
        public void When_Rover_At_3_2_East_And_Move_Should_Be_4_2()
        {
            var direction = new East();
            var newCoordinates = direction.MoveForward(new Coordinates(3, 2));
            Assert.That(newCoordinates.XCoordinate, Is.EqualTo(4));
            Assert.That(newCoordinates.YCoordinate, Is.EqualTo(2));
        }

    }
}
