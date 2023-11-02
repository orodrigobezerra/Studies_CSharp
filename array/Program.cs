internal class Program
{
    private static void Main(string[] args)
    {
        if (args is null)
        {
            throw new ArgumentNullException(nameof(args));
        }

        Console.WriteLine("Criar um array de 5 elementos");
        int[] numeros = new int[5];
        int i;

        for (i = 0; i <= numeros.Length - 1; i++)
        {
            Console.Write("Número? ");
            // para converter valores entre tipos de dados utilizar Convert
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (i = 0; i <= numeros.Length - 1; i++)
        {
            Console.WriteLine(numeros[i]);
        }
    }
}

    
