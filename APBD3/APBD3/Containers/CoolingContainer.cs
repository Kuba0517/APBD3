using APBD3.Load;

namespace APBD3.Containers;

public class CoolingContainer(double height, double ownWeight, double depth, double maxCapacity,
    double temperature, CargoType compatibleCargoType)
    : Container(height, ownWeight, depth, maxCapacity)
{

    public double Temperature { get; set; } = temperature;
    public CargoType CompatibleCargoType { get; set; } = compatibleCargoType;

    public override void Load(Cargo cargo, double mass)
    {
        if (Temperature < cargo.Temperature)
        {
            Console.WriteLine($"Temperatura w kontenerze: {SerialNumber} jest zbyt niska dla produktu: {cargo.CargoName}");
        }
        else if (!CompatibleCargoType.Equals(cargo.CargoType))
        {
            Console.WriteLine($"Typ: ${cargo.CargoType} rożni się od typu kontenera: {CompatibleCargoType}");
        }
        else {
            base.Load(cargo, mass);
        }
    }

    public override void Empty()
    {
        
        
    }
}