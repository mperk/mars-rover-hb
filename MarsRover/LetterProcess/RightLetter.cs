using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.LetterProcess
{
    public class RightLetter : LetterHandler
    {
        public override object Handle(object request)
        {
            Request _request = (Request)request;
            if (_request.Command == 'R')
            {
                _request.Rover._direction = ((int)_request.Rover._direction + 1) > 4 ? Direction.N : _request.Rover._direction + 1;
                return _request;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
