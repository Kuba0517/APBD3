namespace APBD3;

public abstract class Container
{
    private static int _id = 0;

    public int Id { get; } = _id++;
    public double LoadMass { get; set; }
    public double Height { get; set; } 
    public double OwnWeight { get; set; } 
    public double Depth { get; set; } 
    public double MaxCapacity { get; set; } 
    public string SerialNumber { get; }

    protected Container(double loadMass, double height, double ownWeight, 
        double depth, double maxCapacity)
    {
        SerialNumber = GenerateSerialNumber();
    }


    public abstract void Empty();

    public virtual void Load(double mass)
    {
        if(mass)
    }

    private string GenerateSerialNumber()
    {
        return "KON-" + GetType().Name[0] + "-" + _id++;
    }




}