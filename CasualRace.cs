﻿using System.Collections.Generic;
using System.Linq;

public class CasualRace : Race
{
    public CasualRace(int id, int length, string route, int prizePool) 
        : base(id, length, route, prizePool)
    { }

    public override Dictionary<int, int> CalculatePerformance()
    {
        Dictionary<int,int> dic = new Dictionary<int, int>();
        foreach (var participant in this.Participants)
        {
            dic.Add(participant.Id, (participant.HorsePowers/participant.Acceleration)+(participant.Suspension+participant.Durability));
        }

        this.IsFinished = true;
        return dic;
    }
}

