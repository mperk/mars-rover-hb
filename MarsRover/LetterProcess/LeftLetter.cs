using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.LetterProcess
{
    public class LeftLetter : LetterHandler
    {
        public override object Handle(object request)
        {
            Request _request = (Request)request;
            if (_request.Command == 'L')
            {
                _request.Rover._direction = ((int)_request.Rover._direction - 1) < 1 ? Direction.W : _request.Rover._direction - 1;
                return request;
            }
            else
            {
                return base.Handle(request);
            }
        }
    }
}
