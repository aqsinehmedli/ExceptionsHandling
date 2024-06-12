namespace Exception_handling2;


public class KartBloklandiExceptions : Exception
{
    public KartBloklandiExceptions(string message) : base(message)
    {
    }



    public KartBloklandiExceptions()
            : base("Kartınız bloke edildi")
    {

    }
}