internal class Program
{
    private static void Main(string[] args)
    {
        /*Console.WriteLine("Tabuada");

        int x;

        Console.WriteLine("Entre com um número: ");
        x = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine(x);

        Console.WriteLine($"Tabuada de {x}");
        
        for (int i = 1; i < 11; i++)
        {
            Console.WriteLine($"{x} x {i} = {x*i}");
        }*/

        Console.WriteLine("Tabuada do 1 ao 10");

        for (int i = 1; i < 11; i++)
        {
            for (int j = 1; j < 6; j++)
            {
                Console.Write($"{j} x {i} = {i*j}\t");
            }
        
        Console.Write("\n");

        }
        
        Console.Write("\n");

        for (int i = 1; i < 11; i++)
        {
            for (int j = 6; j < 11; j++)
            {
                Console.Write($"{j} x {i} = {i*j}\t");
            }
        
        Console.Write("\n");
        
        }


    }
}