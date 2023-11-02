internal class Program
{
    private static void Main (string[] args)
    {
        Console.WriteLine("Inverter um número");

        int numero, numero_invertido = 0, resto;
        
        Console.Write("Entre com um número: ");
        numero = Convert.ToInt32(Console.ReadLine());

        while (numero != 0)
        {
            resto = numero % 10; 
            numero /= 10; 
            numero_invertido = numero_invertido * 10 + resto;  
        }
        
        Console.WriteLine(numero_invertido);
    }
}