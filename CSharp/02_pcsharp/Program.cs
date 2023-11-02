internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2;
        string? aux1, aux2;      
        
        Console.Write("Número 1: ");
        aux1 = Console.ReadLine(); 
        
        Console.Write("Número 2: ");
        aux2 = Console.ReadLine(); 

        num1 = Convert.ToInt32(aux1);
        num2 = Convert.ToInt32(aux2);

        Console.WriteLine("A soma de " + num1 + " e " + num2 + " é igual a " + (num1+num2));

    }
}

