internal class Program
{
    private static void Main(string[] args)
    {
        int numero = 1;
        string nome;
        string ufcd;
        int nota;
        string auxNota;

        // Contentor para guarda as notas dos alunos, diferença para o array é não ser necessário indicar o número de contentores
        
        List<Notas> turmaPython = new List<Notas>();
        Console.Clear();
        
        Console.WriteLine("Notas escolares");

        Console.WriteLine("UFCD? ");
        ufcd = Console.ReadLine();

        do
        {
            Console.Clear();
            Console.WriteLine($"Introduza as notas da UFCD {ufcd}");
            Console.Write("Nome? ");
            nome = Console.ReadLine();
        
            Console.Write("Nota? ");
            auxNota = Console.ReadLine();
            int.TryParse(auxNota, out nota);

            turmaPython.Add(new Notas(numero, nome, ufcd, nota));
            numero++; 
            
            // Mensagem para informar o utilizador como deve para o while
            Console.WriteLine("Pressione qualquer tecla para continuar ou ");
            Console.WriteLine("Pressione a teclar ESC para terminar");
        } while(Console.ReadKey(true).Key != ConsoleKey.Escape); // Código para determinar a saída do programa
        
        Console.Write("\n");
        // Mostrar dados introduzidos

        Console.WriteLine($"Notas da turmaPython na UFCD {ufcd}");

        foreach (var item in turmaPython)
        {
            
            Console.WriteLine("===================================");
            Console.WriteLine($"{item.Numero} - Aluno: {item.Nome} - Nota: {item.Nota}");
        }

        Console.WriteLine("===================================");


    }
}