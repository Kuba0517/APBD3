using APBD3.Interfaces;

namespace APBD3.Containers;

public class LiquidContainer(double loadMass, double height, double ownWeight, double depth, double maxCapacity)
    : Container(loadMass, height, ownWeight, depth, maxCapacity), IHazardNotifier
{
    public override void Load(double mass)
    {
        base.Load(mass);
    }

    public override void Empty()
    {
        Console.WriteLine("empty");
    }

    public void Warn()
    {
        
    }
}