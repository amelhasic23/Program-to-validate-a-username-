using System;

class Program
{
    static void Main()
    {
        Console.Write("Unesite username: ");
        string username = Console.ReadLine();

        if (ValidirajUsername(username))
        {
            Console.WriteLine("Username je validan.");
        }
        else
        {
            Console.WriteLine("Username nije validan. Mora imati između 5 i 15 znakova i ne sme sadržavati '@'.");
        }
    }

    static bool ValidirajUsername(string username)
    {
        if (username.Length < 5 || username.Length > 15)
            return false;

        if (username.Contains("@"))
            return false;

        return true;
    }
}

