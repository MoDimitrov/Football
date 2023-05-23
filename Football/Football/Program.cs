using System;
using System.Collections.Generic;

namespace Football
{
    class Program
    {
        static void Main(string[] args)
        {
            Coach team1Coach = new Coach("Georgi Georgiev", 53);
            Goalkeeper team1Goalkeeper = new Goalkeeper("Milen Stoqnov", 23, 2, 183);
            Defender team1Defender1 = new Defender("Petko Petkov", 28, 7, 187);
            Defender team1Defender2 = new Defender("Michel Roman", 22, 8, 186);
            Defender team1Defender3 = new Defender("Daniel Georgiev", 30, 12, 180);
            Midfield team1Midfield1 = new Midfield("Vasil Vasilev", 29, 9, 188);
            Midfield team1Midfield2 = new Midfield("Ali Mehmed", 34, 15, 190);
            Midfield team1Midfield3 = new Midfield("Stoqn Dimitrov", 31, 11, 185);
            Midfield team1Midfield4 = new Midfield("Iliqn Todorov", 22, 19, 189);
            Striker team1Striker1 = new Striker("Dimitar Iliev", 32, 22, 188);
            Striker team1Striker2 = new Striker("Denis Onur", 28, 4, 188);
            Striker team1Striker3 = new Striker("Mehmed Ali", 35, 26, 179);
            List<FootballPlayer> team1Players = new List<FootballPlayer>
            {
                team1Goalkeeper,
                team1Defender1,
                team1Defender2,
                team1Defender3,
                team1Midfield1,
                team1Midfield2,
                team1Midfield3,
                team1Midfield4,
                team1Striker1,
                team1Striker2,
                team1Striker3,
            };
            Team team1 = new Team(team1Coach, team1Players);

            Coach team2Coach = new Coach("Mo Stoqnov", 47);
            Goalkeeper team2Goalkeeper = new Goalkeeper("Nikolai Iliev", 32, 1, 196);
            Defender team2Defender1 = new Defender("Kamen Vasilev", 22, 7, 176);
            Defender team2Defender2 = new Defender("Kristiqn Kronovich", 29, 20, 186);
            Defender team2Defender3 = new Defender("Deqn Zahov", 36, 10, 187);
            Defender team2Defender4 = new Defender("Peter Parker", 24, 4, 182);
            Midfield team2Midfield1 = new Midfield("Boris Garvanov", 29, 12, 188);
            Midfield team2Midfield2 = new Midfield("Stanislav Stanislavov", 28, 22, 186);
            Midfield team2Midfield3 = new Midfield("Georgi Gerdanov", 23, 24, 180);
            Striker team2Striker1 = new Striker("Brusil Georgiev", 40, 25, 175);
            Striker team2Striker2 = new Striker("Dimitar Berbatov", 37, 8, 187);
            Striker team2Striker3 = new Striker("Vihur Zahov", 50, 3, 180);

            List<FootballPlayer> team2Players = new List<FootballPlayer>
            {
                team2Goalkeeper,
                team2Defender1,
                team2Defender2,
                team2Defender3,
                team2Defender4,
                team2Midfield1,
                team2Midfield2,
                team2Midfield3,
                team2Striker1,
                team2Striker2,
               team2Striker3,
            };
            Team team2 = new Team(team2Coach, team2Players);
            Referee MainReferee = new Referee("Emiliqn Rainov", 40);
            Referee Assistant1 = new Referee("Ivan Kostadinov", 39);
            Referee Assistant2 = new Referee("Petar Qnkov", 42);

            Game game = new Game(team1, team2, MainReferee);
            game.AddGoal(20, team1Striker1);

            game.AddGoal(18, team2Striker1);
            game.AddGoal(6, team2Striker2);
            game.AddGoal(59, team2Striker3);
            game.PrintResult();
        }
    }
}
