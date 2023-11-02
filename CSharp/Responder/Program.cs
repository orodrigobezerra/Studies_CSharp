internal class Program
{
    private static void Main(string[] args)
    {
        // Responda às questões colocadas desenvolvendo código...

        Console.WriteLine("<Questão 1>");
        Console.WriteLine();

        // Questão 1
        // Escreva uma instrução que mostre no monitor a frase: "Hoje é quarta-feira"
        // digite a instrução a partir da linha 8

        Console.WriteLine("Hoje é quarta-feira");

        Console.WriteLine();
        Console.WriteLine("<Questão 2>");
        Console.WriteLine();

        // Questão 2
        // Escreva uma instrução que mostre no monitor a frase: A data do relógio
        // digite a instrução a partir da linha 15

        Console.WriteLine("A data do relógio");
        Console.WriteLine("07/08/2023");

        Console.WriteLine();
        Console.WriteLine("<Questão 3>");
        Console.WriteLine();

        // Questão 3
        // Escreva instruções que solicite o nome 
        // e mostre o nome no monitor a frase: "Hoje é quarta-feira"
        // digite a instrução a partir da linha 24

        Console.WriteLine("Entre com o nome: ");
        Console.ReadLine();


        // Questão 4
        // Escreva instruções que criem as seguinte variáveis:
        // morada; idade; peso; salario
        // digite a instrução a partir da linha 34

        string morada;
        int idade, peso;
        double salario;

        Console.WriteLine();
        Console.WriteLine("<Questão 5>");
        Console.WriteLine();


        // Questão 5
        // Escreva instruções que mostre:
        // como criar o controlo (escreva as instruções conhecidas)
        // digite a instrução a partir da linha 43

        morada = "Viseu";
        idade = 36;
        peso = 90;
        salario = 1000;
        
        Console.WriteLine("Como criar o controlo: ");
        Console.WriteLine($"Morada: {morada}");  
        Console.WriteLine($"Idade: {idade} anos");
        Console.WriteLine($"Peso: {peso} kg");
        Console.WriteLine($"Salário: {salario}€");

        Console.WriteLine();
        Console.WriteLine("<Questão 6>");
        Console.WriteLine();

        // Questão 6
        // Escreva instruções que mostre:
        // Função para encontrar o menor elemento em um array
        // (Escreva uma função que encontre o menor elemento em um array.)
        // digite a instrução a partir da linha 52
        
        int [] numeros = new int[3];
        
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Digite um número: ");
            numeros[i] = Convert.ToInt32(Console.ReadLine());
        }

        if (numeros.Length > 0)
        {
            int menorNumero = numeros.Min();
            Console.WriteLine("O menor número do array é: " + menorNumero);
        }
        
        Console.WriteLine();
        Console.WriteLine("<Questão 7>");
        Console.WriteLine();
        
        // Questão 7
        // Escreva instruções que mostre:
        // Função para encontrar o elemento máximo em um array
        //(Escreva uma função que encontre o elemento máximo em um array.)
        // digite a instrução a partir da linha 61

        
        if (numeros.Length > 0)
        {
            int maiorNumero = numeros.Max();
            Console.WriteLine("O maior número do array é: " + maiorNumero);
        }

        Console.WriteLine();
        Console.WriteLine("<Questão 8>");
        Console.WriteLine();

        // Questão 8
        // Escreva instruções que mostre:
        // Escreva dois exemplos de loops para imprimir numeros de 1000 a 100
        // digite a instrução a partir da linha 68

        int contDesc;
        contDesc = 1000;

        for (int i = contDesc; i >= 100; i--)
        {
            Console.WriteLine(i);
        }    

        int contDesc2;
        contDesc2 = 1000;
        while (contDesc2 >= 100)
        {
            Console.WriteLine(contDesc2);
            contDesc2--; 
        }
        
    
    }
}