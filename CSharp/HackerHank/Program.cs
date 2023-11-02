internal class Program
{
    private static void Main(string[] args)
    {
        HashSet<int> numbers = new HashSet<int>();
        int nElements = 5;
        Random aleatorio = new Random();       
        
        Console.WriteLine("Numbers: ");
        
        while (nElements > numbers.Count)
        {
            numbers.Add(aleatorio.Next(-10,10));
        }
        
        List<int> numbersList = numbers.ToList();
        numbersList.Sort();

        foreach (int num in numbersList)
        {
            Console.WriteLine(num);
        }

        foreach (int num in numbersList)
        {
            if (num > 0)
            {
                positive = num.Sum() / num;
            }
            Console.WriteLine(num);
        }
    }
}