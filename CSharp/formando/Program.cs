internal class Program
{
    private static void Main(string[] args)
    {
        Formando formando = new Formando(1, "Rodrigo", "Engenharia de Software", 10.9);

        Console.WriteLine(formando.ToString());
    }

}