using Exception_handling2;
using System.Linq.Expressions;
class Program 
{
    int balance = 0;
    string pin = "1234";
    public void CheckPin()
    {
        int count = 0;
        while (count < 3)
        {
            Console.Write("PIN kodunu girin: ");
            string girilenPin = Console.ReadLine();
            if (girilenPin == pin)
            {
                Console.WriteLine("PIN doğru.");
                return;
            }
            else
            {
                count++;
                Console.WriteLine("PIN yanlış. Tekrar daxil edin:");
            }
        }

        throw new KartBloklandiExceptions();
    }
    public void ShowBalance()
    {
        Console.WriteLine("Balance:", balance);
    }
    public void CashOut()
    {
        Console.Write("Istediyiniz mebleg:");
        string amount1 = Console.ReadLine();
        int amount2 = 0;
        if (int.TryParse(amount1, out amount2))
        {
            if (amount2 > balance)
            {
                throw new NotEnoughMoneyException();
            }
            balance -= amount2;


        }

    }
    public void CashIn()
    {
        Console.Write("Istediyiniz mebleg:");
        string amount1 = Console.ReadLine();
        int amount3 = 0;
        if (int.TryParse(amount1, out amount3))
        {
            if (amount3 > balance)
            {
                balance += amount3;
            }


        }
    }
    public void changePin()
    {
        Console.Write("Kecmis pin - i daxil edin:");
        string Pin1 = Console.ReadLine();
        if (Pin1 == pin)
        {
            Console.WriteLine("Yeni pin mueyyenlesdirin!");
            string pin2 = Console.ReadLine();
        }
        else
        {
            throw new IncorrectPinException();

        }

    }
    static void Main(string[] args)
    {
        Program program = new Program();
        try
        {
            program.CheckPin();
            program.ShowBalance();
            program.CashIn();
            program.CashOut();
            program.changePin();
        }
        catch (KartBloklandiExceptions ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (NotEnoughMoneyException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IncorrectPinException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Hata: {ex.Message}");
        }
    }
}




