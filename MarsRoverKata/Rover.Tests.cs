using System;
using NUnit.Framework;
using MarsRover;

namespace MarsRover.Tests
{
    [TestFixture]
    class BasicMoves
    {
        [TestCase]
        public void InitialPosition() {
            var rover = new Rover(2, 4);

            Assert.AreEqual(2, rover.X);
            Assert.AreEqual(4, rover.Y);
        }
    }
}
