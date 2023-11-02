class Contato
{
    //Propriedades da classe
    public int ID { get; set; }

    public string Nome { get; set; }

    public string Apelido { get; set; }

    public string Telemovel { get; set; }

    public DateTime DataNascimento { get; set; }

    // Construtor

    public Contato (int id, string nome, string apelido, string telemovel, DateTime datanascimento)
    {
        this.ID = id;
        this.Nome = nome;
        this.Apelido = apelido;
        this.Telemovel = telemovel;
        this.DataNascimento = datanascimento;
    }

    // Sobrecarga do método ToString()

    public override string ToString ()
    {
        return $"ID: {ID}, Nome: {Nome}, Apelido: {Apelido}, Telemóvel: {Telemovel}, Data de Nascimento: {DataNascimento}";
    }
}