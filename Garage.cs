using System.Collections.Generic;
using System.Linq;

public class Garage
{
    private List<Car> parkedCars;

    public Garage()
    {
        this.parkedCars = new List<Car>();
    }

    public List<Car> ParkedCars
    {
        get { return this.parkedCars; }
        set { this.parkedCars = value; }
    }

    public void ModifyCar(int carId)
    {
        
    }

    public void ParkCar(Car car)
    {
        this.ParkedCars.Add(car);
    }

    public void UnparkCar(Car car)
    {
        this.ParkedCars.Remove(car);
    }
}

