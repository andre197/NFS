using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CarManager
{
    private List<Car> cars = new List<Car>();
    private List<Race> races = new List<Race>();
    private Garage garage = new Garage();

    public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower,
        int acceleration, int suspension, int durability)
    {
        if (type == "Show")
        {
            cars.Add(new ShowCar(id, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
        else
        {
            cars.Add(new PerformanceCar(id, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
        }
    }

    public string Check(int id)
    {
        Car c = cars.Find(x => x.Id == id);

        return c.ToString();
    }

    public void Open(int id, string type, int length, string route, int prizePool)
    {
        if (type == "Drag")
        {
            races.Add(new DragRace(id, length, route, prizePool));
        }
        else if (type == "Drift")
        {
            races.Add(new DriftRace(id, length, route, prizePool));
        }
        else
        {
            races.Add(new CasualRace(id, length, route, prizePool));
        }
    }

    public void Participate(int carId, int raceId)
    {
        Race race = races.Find(r => r.Id == raceId);
        if (!garage.ParkedCars.Exists(c => c.Id == carId) && !race.IsFinished)
        {
            Car car = FindCar(carId);
            race.AddCars(car);
        }
    }

    public string Start(int id)
    {
        Race race = races.Find(r => r.Id == id);
        if (race.Participants.Count != 0 && !race.IsFinished)
        {
            var dic = race.CalculatePerformance().OrderByDescending(x => x.Value).Take(3);
            string sb = $"{race.Route} - {race.Length}";
            int cnt = 0;
            foreach (var item in dic)
            {
                cnt++;
                Car car = FindCar(item.Key);
                int percent;

                if (cnt == 1)
                {
                    percent = 50;
                }
                else if (cnt == 2)
                {
                    percent = 30;
                }
                else
                {
                    percent = 20;

                }
                sb = sb + Environment.NewLine + $@"{cnt}. {car.Brand} {car.Model} {item.Value}PP - ${(race.PrizePool * percent) / 100}";

            }

            return sb;
        }
        return "Cannot start the race with zero participants.";
    }

    public void Park(int id)
    {
        bool isInRace = IsInRace(id);
        if (!isInRace)
        {
            Car car = FindCar(id);
            garage.ParkCar(car);
        }
    }

    public void Unpark(int id)
    {
        Car car = FindCar(id);
        garage.UnparkCar(car);
    }

    public void Tune(int tuneIndex, string addOn)
    {
        foreach (var car in garage.ParkedCars)
        {
            car.Tune(tuneIndex, addOn);
        }
    }

    private Car FindCar(int id)
    {
        return cars.Find(c => c.Id == id);

    }

    private bool IsInRace(int id)
    {
        foreach (var race in races)
        {
            foreach (var participant in race.Participants)
            {
                if (participant.Id == id)
                {
                    return true;
                }
            }
        }
        return false;
    }
}

