using APBD3.Interfaces;

namespace APBD3.Containers;

public class GasContainer(double loadMass, double height, double ownWeight, double depth, double maxCapacity, double pressure)
    : Container(loadMass, height, ownWeight, depth, maxCapacity), IHazardNotifier
{

    public double Pressure { get; set; } = pressure;

    public override void Empty()
    {
        throw new NotImplementedException();
    }

    public void Warn()
    {
        throw new NotImplementedException();
    }
}