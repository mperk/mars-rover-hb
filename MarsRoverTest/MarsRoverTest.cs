using MarsRover;
using Moq;
using System;
using Xunit;

namespace MarsRoverTest
{
    public class MarsRoverTest
    {
        [Fact]
        public void NavigateTurnLeft_ShouldWest_WhenNorth()
        {
            var rover = new Rover(new Position(5,5), new Position(1,2), Direction.N);
            rover.Navigate("L");
            Assert.Equal(Direction.W, rover._direction);
        }

        [Fact]
        public void NavigateTurnRight_ShouldSouth_WhenEast()
        {
            var rover = new Rover(new Position(5, 5), new Position(1, 2), Direction.E);
            rover.Navigate("R");
            Assert.Equal(Direction.S, rover._direction);
        }

        [Fact]
        public void Navigate_Move()
        {
            var rover = new Rover(new Position(5, 5), new Position(1, 2), Direction.E);
            rover.Navigate("M");
            Assert.Equal(2, rover._position.X);
            Assert.Equal(2, rover._position.Y);
        }

        [Fact]
        public void NavigateInvalidChar_ShouldException_WherLetterInvalid()
        {
            var rover = new Rover(new Position(5, 5), new Position(1, 2), Direction.E);
            var result = Record.Exception(() => rover.Navigate("MRR3"));
            Assert.NotNull(result);
        }
    }
}
