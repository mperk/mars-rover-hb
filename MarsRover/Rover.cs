using MarsRover.LetterProcess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover : IRover
    {
        public Position _upperRight { get; set; }

        public Position _position { get; set; }

        public Direction _direction { get; set; }

        public Rover(Position upperRight, Position position, Direction direction)
        {
            _position = position;
            _direction = direction;
            _upperRight = upperRight;
        }

        public void Navigate(string letters)
        {
            var left = new LeftLetter();
            var right = new RightLetter();
            var move = new MoveLetter();
            left.SetNext(right).SetNext(move);
            foreach (var letter in letters)
            {
                var req = new Request(this, letter);
                left.Handle(req);
            }
        }

    }
}
