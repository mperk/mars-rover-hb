using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            var positionFirst = new Position(1, 2);
            var roverFirst = new Rover(new Position(5, 5), positionFirst, Direction.N);
            roverFirst.Navigate("LMLMLMLMM");
            Console.WriteLine(roverFirst._position.X + " " + roverFirst._position.Y + " " + roverFirst._direction.ToString());

            var positionSecond = new Position(3, 3);
            var roverSecond = new Rover(new Position(5, 5), positionSecond, Direction.E);
            roverSecond.Navigate("MMRMMRMRRM");
            Console.WriteLine(roverSecond._position.X + " " + roverSecond._position.Y + " " + roverSecond._direction.ToString());
            Console.ReadLine();
        }
    }
}
