using APBD3.Containers;
using APBD3.Load;

public class Program
{
    public static void Main(string[] args)
    {
        LiquidContainer lq = new LiquidContainer( 20.2, 20.3, 10.2, 50.0);
        GasContainer gc = new GasContainer(20, 100, 18, 1500, 1024);
        CoolingContainer cc = new CoolingContainer(20, 100, 18, 1100, 5, CargoType.Dairy);
        
        Console.WriteLine(lq.SerialNumber);
        Console.WriteLine(gc.SerialNumber);
        Console.WriteLine(cc.SerialNumber);
        
        
    }
}