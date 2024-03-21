using APBD3.Containers;

namespace APBD3.Vehicles;

public class ContainerShip
{
    private static int _id = 0;
    public static int Id { get; } = _id++;
    public List<Container> Containers { get; set; }
    public double MaxSpeed { get; set; }
    public int MaxContainersCount { get; set; }
    public double MaxContainersWeight { get; set; }
    public double CurrentWeight { get; set; }

    public ContainerShip(double maxSpeed, int maxContainersCount, double maxContainersWeight)
    {
        MaxSpeed = maxSpeed;
        MaxContainersCount = maxContainersCount;
        MaxContainersWeight = maxContainersWeight;
        Containers = new List<Container>();
        CurrentWeight = 0;
    }
    
    public ContainerShip(double maxSpeed, int maxContainersCount, double maxContainersWeight, 
        List<Container> containers)
    {
        MaxSpeed = maxSpeed;
        MaxContainersCount = maxContainersCount;
        MaxContainersWeight = maxContainersWeight;
        Containers = new List<Container>();
        CurrentWeight = CountWeight(containers);
    }

    public void LoadContainer(params Container[] containers)
    {
        foreach (Container con in Containers)
        {
            if (ValidateContainer(con))
            {
                Containers.Add(con);
                CurrentWeight += con.LoadMass + con.OwnWeight;
            }
        }
    }

    public void DeleteContainer(String serialNumber)
    {
        foreach (Container con in Containers)
        {
            if (con.SerialNumber.Equals(serialNumber))
            {
                CurrentWeight -= con.OwnWeight + con.LoadMass;
                Containers.Remove(con);
                break;
            }
        }
    }
    
    public void ReplaceContainer(String serialNumber, Container container)
    {
        foreach (Container con in Containers)
        {
            if (con.SerialNumber.Equals(serialNumber))
            {
                CurrentWeight -= con.OwnWeight + con.LoadMass;
                Containers.Remove(con);
                Containers.Add(container);
                CurrentWeight += container.OwnWeight + container.LoadMass;
                break;
            }
        }
    }

    private bool ValidateContainer(Container container)
    {
        return MaxContainersCount >= Containers.Count + 1 && MaxContainersWeight >= CurrentWeight + container.OwnWeight
            + container.LoadMass;
    }

    private double CountWeight(List<Container> containers)
    {
        double result = 0;
        foreach (Container con in containers)
        {
            result += con.OwnWeight + con.LoadMass;
        }

        return result;
    }
}