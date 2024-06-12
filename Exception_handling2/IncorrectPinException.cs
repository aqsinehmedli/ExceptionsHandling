namespace Exception_handling2;

public class IncorrectPinException : Exception
{
    public IncorrectPinException(string message) : base(message)
    {

    }
    public IncorrectPinException()
        : base("Pin yanlisdir!")
    {
    }
}
