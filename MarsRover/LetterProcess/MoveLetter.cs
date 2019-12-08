namespace MarsRover.LetterProcess
{
    public class MoveLetter : LetterHandler
    {
        public override object Handle(object request)
        {
            Request _request = (Request)request;
            if (_request.Command == 'M')
            {
                if (_request.Rover._direction == Direction.N && _request.Rover._upperRight.Y > _request.Rover._position.Y)
                {
                    _request.Rover._position.Y += 1;
                }
                else if (_request.Rover._direction == Direction.S && RoverConst.LowerLeftY < _request.Rover._position.Y)
                {
                    _request.Rover._position.Y -= 1;
                }
                else if (_request.Rover._direction == Direction.E && _request.Rover._upperRight.X > _request.Rover._position.X)
                {
                    _request.Rover._position.X += 1;
                }
                else if (_request.Rover._direction == Direction.W && RoverConst.LowerLeftX < _request.Rover._position.X)
                {
                    _request.Rover._position.X -= 1;
                }
                return _request;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
