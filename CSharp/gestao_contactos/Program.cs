internal class Program
{
    private static void Main(string[] args)
    {
        
        int i = 1;
        string nome, apelido, telemovel;
        DateTime datanascimento;

        do
        {
            Console.Write("Entre com o nome: ");
            nome = Console.ReadLine();
            
            Console.Write("Entre com o apelido: ");
            apelido = Console.ReadLine();
            
            Console.Write("Entre com o nº de telmóvel: ");
            telemovel = Console.ReadLine();

            datanascimento = DateTime.Now;

            i++;

        }while(false);


        Contato contato = new Contato();

        Console.WriteLine(contato.ToString(Contato));


    }
}