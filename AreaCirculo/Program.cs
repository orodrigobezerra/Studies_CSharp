internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Cálculo da área de um círculo");
        Console.WriteLine();

        double raio, area, pi=3.14;
        
        Console.Write("Entre com o valor do raio: ");
        raio = Convert.ToInt32(Console.ReadLine());
        
        area = pi * raio * raio;

        Console.WriteLine();
        Console.WriteLine("A área do círculo é: " + area);

    }
}