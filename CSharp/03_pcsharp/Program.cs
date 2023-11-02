internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Declarar e atribuir valores ao array");

        //declarar array
        int[] numeros = new int[5]; //int numeros[20];
        int i;

        for (i = 0; i < numeros.Length; i++)
        {
            Console.Write($"{i+1}º Número: "); //interpolação -> formatar texto no WL
            //numeros[i] = Int32.Parse(Console.ReadLine()); //Convert.ToInt32()
            Int32.TryParse(Console.ReadLine(), out numeros[i]);
        }

        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        Array.Sort(numeros);
        
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }

        Array.Reverse(numeros);
        
        foreach (int num in numeros)
        {
            Console.WriteLine(num);
        }
    }
}