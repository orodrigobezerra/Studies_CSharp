internal class Program
{
    private static void Main(string[] args)
    {
        Circulo circulo1 = new Circulo();
      
        Console.WriteLine("Entre com o valor do 1º raio: ");
        circulo1.Raio = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Dados do 1º Círculo");
        Console.WriteLine("===========================================");
        Console.WriteLine($"- O raio do círculo 1 é {circulo1.Raio:F2}");
        Console.WriteLine("===========================================");
        Console.WriteLine($"- A área do círculo 1 é {circulo1.Area():F2}");
        Console.WriteLine("===========================================");
        Console.WriteLine($"- O perímetro do círculo 1 é {circulo1.Perimetro():F2}");
        Console.WriteLine("===========================================");

        Console.WriteLine(circulo1.ToString());

        Console.WriteLine("--------------------------------------------");
        
        Circulo circulo2 = new Circulo(6.1);

        Console.WriteLine("Entre com o valor do 2º raio: ");
        circulo2.Raio = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Dados do 2º Círculo");
        Console.WriteLine("===========================================");
        Console.WriteLine($"- O raio do círculo 2 é {circulo2.Raio:F2}");
        Console.WriteLine("===========================================");
        Console.WriteLine($"- A área do círculo 2 é {circulo2.Area():F2}");
        Console.WriteLine("===========================================");
        Console.WriteLine($"- O perímetro do círculo 2 é {circulo2.Perimetro():F2}");
        Console.WriteLine("===========================================");

        Console.WriteLine(circulo2.ToString());

        Console.WriteLine("--------------------------------------------");

    }
}