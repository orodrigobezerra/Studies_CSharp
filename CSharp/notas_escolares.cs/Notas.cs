class Notas
{
    public int Numero { get; set; }

    public string Nome { get; set; }

    public string UFCD { get; set; }    

    public int Nota { get; set; } 

    public Notas(int numero, string nome, string ufcd, int nota)
    {
        this.Numero = numero;
        this.Nome = nome;
        this.UFCD = ufcd;
        this.Nota = nota;
    }
}