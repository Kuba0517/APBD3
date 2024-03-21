namespace APBD3.Load;

public class Cargo(string cargoName,CargoType cargoType,double temperature, bool hazardous)
{
    public string CargoName { get; } = cargoName;
    public CargoType CargoType { get; } = cargoType;
    public double Temperature { get; } = temperature;
    public bool Hazardous { get; } = hazardous;
}

public enum CargoType
{
    Fruit,
    Meat,
    Dairy,
    Fuel,
    Chemical
}