// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// Console.WriteLine("Vamos Começar por aqui");

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Olá, seja bem vindo {name}!" );
        Console.Write("Digita o ano do seu nascimento: ");
        int year = int.Parse(Console.ReadLine());
        int age = 2024 - year;
        Console.WriteLine($"Você tem {age} anos. ");
        
        if (age >= 18) Console.WriteLine("Você tem maior de idade.");
        else Console.WriteLine("Você é de menor");

    }
}



