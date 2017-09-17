using System;
using System.Collections.Generic;

public class PerformanceCar : Car
{
    private List<string> addOns;

    public PerformanceCar(int id, string brand, string model, int yearOfProduction, int horsePowers, int acceleration,
        int suspension, int durability)
        : base(id, brand, model, yearOfProduction, ((horsePowers * 150) / 100), acceleration, ((suspension * 75)/100), durability)
    {
        this.addOns=new List<string>();
    }
    

    public void AddAdds(string add)
    {
        this.addOns.Add(add);
    }

    public override void Tune(int index, string addsOn)
    {
        base.Tune(index, addsOn);
        AddAdds(addsOn);
    }

    public override string ToString()
    {
        string adds = null;
        if (this.addOns.Count == 0)
        {
            adds=$"None";
        }
        else
        {
            adds = string.Join(", ", this.addOns);
        }
        return base.ToString() + Environment.NewLine + $"Add-ons: {adds}";
    }

    
}

