namespace APBD3;

public class LiquidContainer(double loadMass, double height, double ownWeight, 
    double depth, double maxCapacity) : Container(loadMass, height, ownWeight, depth, maxCapacity)
{
    
    public override void Empty()
    {
        Console.WriteLine("empty");
    }
}