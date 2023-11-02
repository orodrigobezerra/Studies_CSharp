internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Sortear números do EuroMilhões");
        
        HashSet<int> numeros = new HashSet<int>(); //permite guardar valores [int] sem repetição
        HashSet<int> estrelas = new HashSet<int>(); //permite guardar valores [int] sem repetição
        Random aleatorio = new Random();
        int nElementos = 5;
        int nEstrelas = 2;

        Console.WriteLine("Números: ");
        
        while (nElementos > numeros.Count) 
        {
            numeros.Add(aleatorio.Next(1,51));
        } 
        
        //List<int> numerosOrdenados = numeros.ToList();//transforma uma HashSet em Lista para poder ordenar
        //numerosOrdenados.Sort();

        // Utilizar a técnica do LINQ
        var numerosOrdenados = numeros.OrderBy(num => num);


        foreach (var item in numerosOrdenados)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine("Estrelas ⭐");
        
        while (nEstrelas > estrelas.Count) 
        {
            estrelas.Add(aleatorio.Next(1,13));
        } 

       //List<int> estrelasOrdenadas = estrelas.ToList();
       //estrelasOrdenadas.Sort();

       
       // Utilizar a técnica do LINQ
       var estrelasOrdenadas = estrelas.OrderBy(est => est);

        foreach (var item in estrelasOrdenadas)
        {
            Console.WriteLine(item);
        }
    }   


}