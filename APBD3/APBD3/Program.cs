using APBD3.Containers;
using APBD3.Load;

public class Program
{
    public static void Main(string[] args)
    {
        LiquidContainer lq = new LiquidContainer( 20.2, 20.3, 10.2, 1000);
        GasContainer gc = new GasContainer(20, 100, 18, 1500, 1024);
        CoolingContainer cc = new CoolingContainer(20, 100, 18, 1100, 5, CargoType.Dairy);
        
        Console.WriteLine(lq.SerialNumber);
        Console.WriteLine(gc.SerialNumber);
        Console.WriteLine(cc.SerialNumber);
        
        cc.Load(new Cargo("Jajka", CargoType.Chemical, 5, false), 1000);
        
        gc.Load(new Cargo("Hel", CargoType.Fuel, 10, false), 500);
        Console.WriteLine(gc.LoadMass);
        gc.Empty();
        Console.WriteLine(gc.LoadMass);
        Console.WriteLine(gc.ContainerCargo.CargoName);

        lq.Load(new Cargo("Etanol", CargoType.Chemical, 6, true), 1000);
    }
}