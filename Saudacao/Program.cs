internal class Program
{
    private static void Saudar(string n)
    {
        Console.WriteLine("Bem vindo(a) à formação, " + n + ". Esteja à vontade :) ");
    }

    private static string Nome()
    {
        Console.WriteLine("Digite o seu nome: ");
        string nom = Console.ReadLine();
        return nom;
    }

    private static void Main(string[] args)
    {
        string nom = Nome();
        Saudar(n: nom);
    }
}
