using APBD3.Containers;

public class Program
{
    public static void Main(string[] args)
    {
        LiquidContainer lq = new LiquidContainer(10.0, 20.2, 20.3, 10.2, 50.0);
        LiquidContainer lq2 = new LiquidContainer(10.0, 20.2, 20.3, 10.2, 50.0);
        LiquidContainer lq3 = new LiquidContainer(10.0, 20.2, 20.3, 10.2, 50.0);
        Console.WriteLine(lq.SerialNumber);
        Console.WriteLine(lq3.SerialNumber);
    }
}