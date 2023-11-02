internal class Program
{
    public static void Main(string[] args)
    {
        string[] alunos = new string[3];
        int[,] notas = new int[3, 3];

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine("Digite o nome do aluno:");
            alunos[i] = Console.ReadLine();

            for (int j = 0; j < notas.GetLength(1); j++)
            {
                int nota;
                do
                {
                    Console.WriteLine($"Digite a nota do trimestre {j + 1} de {alunos[i]}:");
                } while (!int.TryParse(Console.ReadLine(), out nota) || nota < 0 || nota > 21);

                notas[i, j] = nota;
            }
        }

        // Visualizar o nome dos alunos e suas notas
        Console.ForegroundColor = ConsoleColor.DarkGray;
        Console.WriteLine("==============================================================================================\t");
        Console.Write("Aluno\t\tTrimestre 1\tTrimestre 2\tTrimestre 3\tMédia\t\tClassificação\n");
        //Console.ResetColor(); 

        for (int i = 0; i < alunos.Length; i++)
        {
            
            Console.WriteLine("==============================================================================================\t");
            Console.ResetColor(); 

            Console.Write($"{alunos[i]}\t\t");
            int soma = 0;
            for (int j = 0; j < notas.GetLength(1); j++)
            {
                Console.Write($"{notas[i, j]}\t\t");
                soma += notas[i, j];
            }
            float media = soma / 3f;  // Calcula a média
            Console.Write($"{media:F1}\t\t");  // Imprime a média com uma casa decimal

            // Determina a classificação
            if (media < 9.5)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Reprovado\t\t");  // Imprime "Reprovado" em vermelho
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Aprovado\t\t");  // Imprime "Aprovado" em verde
            }
            
            Console.ResetColor();  // Restaura a cor original
            Console.WriteLine();

            Console.WriteLine("==============================================================================================\t");
        }
    }

}