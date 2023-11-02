internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Manipulação de matrizes");

        // Matrizes -> Arrays

        int[] valores = new int[10];
        
        for (int i = 0; i < valores.Length; i++)
        {
            Console.WriteLine("Digite um número: ");
            valores[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < valores.Length; i++)
        {
            Console.WriteLine($"O elemento {i} contém {valores[i]}"); //O '$' permite escrever números e letras dentro das ""
        }


    }
}