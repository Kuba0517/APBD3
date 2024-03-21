using APBD3.Interfaces;
using APBD3.Load;

namespace APBD3.Containers;

public class GasContainer(double height, double ownWeight, double depth, double maxCapacity, double pressure)
    : Container(height, ownWeight, depth, maxCapacity), IHazardNotifier
{

    public double Pressure { get; set; } = pressure;
    

    public override void Empty()
    {
        LoadMass *= 0.05;
    }

    public void Warn()
    {
       Console.WriteLine("Niebezpieczna sytuacja w kontenerze:  " + SerialNumber);
    }
}