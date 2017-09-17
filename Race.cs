using System.Collections.Generic;

public abstract class Race
{
    private int id;
    private int length;
    private string route;
    private int prizePool;
    private List<Car> participants;
    private bool isFinished = false;

    protected Race(int id, int length, string route, int prizePool)
    {
        this.Id = id;
        this.length = length;
        this.route = route;
        this.prizePool = prizePool;
        this.participants = new List<Car>();
    }

    public int Id
    {
        get { return this.id; }
        protected set { this.id = value; }
    }

    public int Length
    {
        get { return this.length; }
        protected set { this.length = value; }
    }

    public string Route
    {
        get { return this.route; }
        protected set { this.route = value; }
    }

    public int PrizePool
    {
        get { return this.prizePool; }
        protected set { this.prizePool = value; }
    }

    public List<Car> Participants
    {
        get { return this.participants; }
        protected set { this.participants = value; }
    }

    public bool IsFinished
    {
        get { return this.isFinished; }
        protected set { this.isFinished = value; }
    }

    public abstract Dictionary<int,int> CalculatePerformance();

    public void AddCars(Car car)
    {
        this.Participants.Add(car);
    }
}

