using APBD3.Interfaces;
using APBD3.Load;

namespace APBD3.Containers;

public class LiquidContainer(double height, double ownWeight, double depth, double maxCapacity)
    : Container(height, ownWeight, depth, maxCapacity), IHazardNotifier
{
    public override void Load(Cargo cargo,double mass)
    {
        base.Load(cargo,mass);
        if (cargo.Hazardous)
        {
            MaxCapacity *= 0.5;
        }
        else
        {
            MaxCapacity *= 0.9;
        }

        if (mass > MaxCapacity)
        {
            Warn();
        }
    }
    

    public void Warn()
    {
        Console.WriteLine("Niebezpieczny sytuacja w kontenerze: " + SerialNumber);
    }
}