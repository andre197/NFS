using System;

public abstract class Car
{
    private int id;
    private string brand;
    private string model;
    private int yearOfProduction;
    private int horsePowers;
    private int acceleration;
    private int suspension;
    private int durability;

    public Car(int id, string brand, string model, int yearOfProduction, int horsePowers, int acceleration, int suspension, int durability)
    {
        this.Id = id;
        this.Brand = brand;
        this.Model = model;
        this.YearOfProduction = yearOfProduction;
        this.HorsePowers = horsePowers;
        this.Acceleration = acceleration;
        this.Suspension = suspension;
        this.Durability = durability;
    }

    public int Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public string Brand
    {
        get { return this.brand; }
        protected set { this.brand = value; }
    }
    public string Model
    {
        get { return this.model; }
        protected set { this.model = value; }
    }

    protected int YearOfProduction
    {
        get { return this.yearOfProduction; }
        set { this.yearOfProduction = value; }
    }
    public int HorsePowers
    {
        get { return this.horsePowers; }
        protected set { this.horsePowers = value; }
    }
    public int Acceleration
    {
        get { return this.acceleration; }
        protected set { this.acceleration = value; }
    }
    public int Suspension
    {
        get { return this.suspension; }
        protected set { this.suspension = value; }
    }
    public int Durability
    {
        get { return this.durability; }
        protected set { this.durability = value; }
    }

    public virtual void Tune(int index, string addsOn)
    {
        this.HorsePowers += index;
        this.Suspension += index / 2;
    }

    public override string ToString()
    {
        return $"{this.Brand} {this.Model} {this.YearOfProduction}" + Environment.NewLine + $"{this.HorsePowers} HP, 100 m/h in {this.Acceleration} s" + Environment.NewLine + $"{this.Suspension} Suspension force, {this.Durability} Durability";
    }
}

