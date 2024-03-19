using APBD3;

public class Program
{
    public static void Main(string[] args)
    {
        LiquidContainer lq = new LiquidContainer(10.0, 20.2, 20.3, 10.2, 50.0);
        Console.WriteLine(lq.SerialNumber);
    }
}