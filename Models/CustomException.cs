namespace LesExceptions.Models
{
    public class CustomException : Exception
    {
        public DateTime TimeRaised { get; }

        public CustomException(string message) : base(message)
        {
            TimeRaised = DateTime.Now;
        }


    }
}
