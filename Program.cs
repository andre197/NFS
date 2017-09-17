
using System;

public class Program
{
    public static void Main(string[] args)
    {
        CarManager manager = new CarManager();

        while (true)
        {
            var input = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "Cops" )
            {
                break;
            }

            if (input[0] == "register")
            {
                manager.Register(int.Parse(input[1]),input[2],input[3],input[4],int.Parse(input[5])
                    ,int.Parse(input[6]),int.Parse(input[7]),int.Parse(input[8]),int.Parse(input[9]));
            }
            else if (input[0] == "open")
            {
                manager.Open(int.Parse(input[1]),input[2],int.Parse(input[3]),input[4],int.Parse(input[5]));
            }
            else if (input[0] == "participate")
            {
                manager.Participate(int.Parse(input[1]),int.Parse(input[2]));
            }
            else if (input[0] == "check")
            {
                Console.WriteLine(manager.Check(int.Parse(input[1])));
            }
            else if (input[0] == "park")
            {
                manager.Park(int.Parse(input[1]));
            }
            else if (input[0] == "unpark")
            {
                manager.Unpark(int.Parse(input[1]));
            }
            else if (input[0] == "tune")
            {
                manager.Tune(int.Parse(input[1]),input[2]);
            }
            else if (input[0] == "start")
            {
                Console.WriteLine(manager.Start(int.Parse(input[1])));
            }
        }
    }

}
