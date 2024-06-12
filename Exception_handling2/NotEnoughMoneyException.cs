namespace Exception_handling2;

public class NotEnoughMoneyException : Exception
{
    public NotEnoughMoneyException(string message) : base(message)
    {

    }
    public NotEnoughMoneyException()
        : base("Yeterli mebleg yoxdur!")
    {

    }
}
