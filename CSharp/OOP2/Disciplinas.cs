class Disciplinas
{
    //Propriedades da classe
    public string Disciplina { get; set;}

    public double Nota { get; set;}
    
    // Criar construtor
    public Disciplinas () // Construtor vazio, vai guardar espaço para receber valores
    {
        // intencionalmente vazio
    }
    public Disciplinas (string disciplina, double nota) // quando usar esse construtor temos de usar a disciplina e a nota
    {
        this.Disciplina = disciplina; // atribuimos valores
        this.Nota = nota; // atribuimos valores
    }
}