class Circulo
{
    
    //propriedades
    public double Raio { get; set; }

    //construtores
    public Circulo ()
    {

    }

    public Circulo (double raio)
    {
        this.Raio = raio;
    }

    //métodos

    public double Area()
    {
        return this.Raio * Raio * 3.1415; 
    }

    public double Perimetro()
    {
        return 2 * 3.1415 * this.Raio;
    }

    public override string ToString()
    {
        return $"- O raio do círculo é {Raio:F2}\n- A área do círculo 1 é {Area():F2}\n- O perímetro do círculo 1 é {Perimetro():F2}";
    }
}