namespace APBD3.Containers;

public class CoolingContainer(double loadMass, double height, double ownWeight, double depth, double maxCapacity, double temperature)
    : Container(loadMass, height, ownWeight, depth, maxCapacity)
{

    public double Temperature { get; set; } = temperature;
    
    
    public override void Empty()
    {
        throw new NotImplementedException();
    }
}