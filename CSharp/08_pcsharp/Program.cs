internal class Program
{
    /*
    Solicitar 10 nomes correspondentes a 10 alunos
    Solicitar as notas de matemática do primeiro, segundo e terceiro trimeste
    Apresentar os valores de forma tabular: aluno / 1º tri / 2º tri / 3º tri
    Calcule a média e adicione a visualização
    Mostre a classificação sabendo que <9,5 reprova. restante é aprovado
    */
    
    private static void Main(string[] args)
    {
        string[] alunos = new string[3];
        int[,] notas = new int[3,3]; //Array multidimensional
        
        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine("Insira o nome do aluno: ");
            alunos[i] = Console.ReadLine();
            
            //Solicitar notas

            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine($"Insira a nota de {j+1}º. de {alunos[i]}");
                notas[i,j] = int.Parse(Console.ReadLine());
            }

        }
        
        Console.WriteLine("Alunos\t1º trimestre\t2º trimestre\t3º trimestre\t\tMédia\t\tStatus");
        
        for(int j = 0; j < 3; j++)
        {
            Console.Write($"{alunos[j]}\t\t");

            double media = 0;

            for(int i = 0; i < 3; i++)
            {
                Console.Write($"{notas[j, i]}\t\t");

                media += notas[j,i]; //é += pq são 3 notas
            }

            media /= 3;

            Console.Write($"{media:F2}\t\t");

            if(media < 9.5)
            {
                Console.Write("X");
            }
            else
            {
                Console.Write("V");
            }
            
            Console.Write("\n");
        }
    }
}