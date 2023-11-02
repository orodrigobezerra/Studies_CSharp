internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Exemplo de Lambda");

        Func<int, int> quadrado = x => x * x;

        Console.WriteLine(quadrado(5));
    }

    int valorAoQuadrado(int x)
    {
        return x*x;
    }
}