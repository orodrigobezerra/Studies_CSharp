internal class Program
{
    private static void Main(string[] args)
    {
        Aluno aluno = new Aluno("Rodrigo", "Nunes");
        Aluno aluno2 = new Aluno("Filipe","Ferrão");
        Aluno aluno3 = new Aluno();
        aluno3.Nome = "Luís"; // utilização da propriedade set, significa atribuir valor a minha variável
        aluno3.Apelido = "Camões";
        Console.WriteLine(aluno.Apelido); // Utilização da propriedade get, significa obtençao de valores para a variável
        Console.WriteLine(aluno2.Apelido);
        Console.WriteLine(aluno3.Apelido);
    }
}