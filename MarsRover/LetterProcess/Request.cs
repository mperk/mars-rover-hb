namespace MarsRover.LetterProcess
{
    public class Request
    {

        public Rover Rover { get; set; }

        public char Command { get; set; }

        public Request(Rover rover, char command)
        {
            Rover = rover;
            Command = command;
        }
    }
}
