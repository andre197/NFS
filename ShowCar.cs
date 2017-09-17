using System;

public class ShowCar : Car
{
    private int stars;

    public ShowCar(int id, string brand, string model, int yearOfProduction, int horsePowers, int acceleration, int suspension, int durability)
        : base(id, brand, model, yearOfProduction, horsePowers, acceleration, suspension, durability)
    {
        this.Stars = 0;

    }

    protected int Stars
    {
        get { return this.stars; }
        set { this.stars = value; }
    }

    public void IncreaseStars(int amount)
    {
        this.Stars += amount;
    }

    public override void Tune(int index, string addsOn)
    {
        base.Tune(index, addsOn);
        IncreaseStars(index); 
    }

    public override string ToString()
    {
        return base.ToString() + Environment.NewLine + $"{this.Stars} *";
    }

   
}

