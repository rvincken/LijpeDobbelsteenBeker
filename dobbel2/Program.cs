namespace dobbel2;

internal class Program
{
    static void Main()
    {
        var dobbelstenen = new List<Dobbelsteen>
        {
            new Dobbelsteen("rood", "vierkant", new List<int> { 1, 2, 3, 4, 5, 6 }),
            new Dobbelsteen("blauw", "rond", new List<int> { 1, 2, 3, 4, 5, 6 }),
            new Dobbelsteen("groen", "ster", new List<int> { 1, 2, 3, 4, 5, 6 })
        };
        
        Beker beker = new Beker(dobbelstenen);
        
        List<int> resultaten = beker.DoeWorp();
        
        Console.WriteLine("Geworpen dobbelstenen:");
        foreach (int resultaat in resultaten)
        {
            Console.WriteLine(resultaat);
        }
    }
}