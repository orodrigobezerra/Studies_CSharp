internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("* Soma de 2 números *");
        Console.WriteLine();

        // Declarando as variáveis

        int num1, num2, soma;

        // Solicitar números ao utilizador
        // ReadLine devolve sempre strings
        // Convert.Int32()- converte para números inteiros
        Console.Write("Entre com o primeiro número: ");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Entre com o segundo número: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        soma = num1 + num2;

        // .ToString() - converte para texto

        Console.WriteLine("A soma de " + num1 + " + " + num2 + " é igual a " + soma.ToString());
    }
}