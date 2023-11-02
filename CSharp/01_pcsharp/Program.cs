internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!"); //printf("Hello, World!\n");
        Console.Write("Hello, World!"); //printf("Hello, World!");
        Console.Write("Hello, World!"); //printf("Hello, World!");
        Console.Write("Hello, World!\n"); //printf("Hello, World!");
        Console.Write("Hello, World!\n"); //printf("Hello, World!");

        int valor;
        valor = 10; 

        Console.WriteLine(valor);

        //If simples
        if (valor == 10)
        {
            Console.WriteLine("Dez");
        }
        
        //If else -> true or false
        if (valor <= 10)
        {
            for (int i = 0; i <10; i++) // for -> ciclo
            {
                Console.WriteLine(i+1);
            }
        }
        else
        {
            Console.WriteLine("É maior que dez");
        }

        while (valor <= 10) // while -> ciclo infinito
        {
            int i = 10;
            while (i >= 1)
            {
                Console.WriteLine(i);
                i--;
            }
            break;
        }
    }
}