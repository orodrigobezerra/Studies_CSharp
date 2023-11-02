class Formando
{
// Propriedades
    public int ID { get; set; }
    public string Nome { get; set; }
    public string Disciplina { get; set; }
    public double Nota { get; set; }


    //Construtor

    public Formando (int id, string nome, string disciplina, double nota)
    {
        this.ID = id;
        this.Nome = nome;
        this.Disciplina = disciplina;
        this.Nota = nota;
    }


    // Método

    public void MostrarFormando()
    {
        Console.WriteLine($"ID: {ID}, Nome: {Nome}, Disciplina: {Disciplina}, Nota: {Nota}");
    }

    // Reescrever método ToString()

    public override string ToString()
    {
        return $"ID: {ID}, Nome: {Nome}, Disciplina: {Disciplina}, Nota: {Nota}";
    }

}