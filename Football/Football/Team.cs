using System;
using System.Collections.Generic;
using System.Text;

namespace Football
{
    public class Team
    {
        public Coach Coach { get; set; }
        public List<FootballPlayer> players;
        public List<FootballPlayer> Players
        {
            get { return players; }
            set
            {
                if (value.Count < 11 || value.Count > 22)
                {
                    throw new Exception("The team must have between 11 and 22 players");
                }
                players = value;
            }
        }
        public Team(Coach coach, List<FootballPlayer> players)
        {
            Coach = coach;
            Players = players;
        }

        public double AverageAge
        {
            get
            {
                int totalAge = 0;
                foreach (var item in Players)
                {
                    totalAge += item.Age;
                }
                return (double)totalAge / Players.Count;
            }
        }
    }
}
