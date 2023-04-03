
public class app
{
    public static void Main()
    {
        List<Team> teams = new List<Team>
        {
            new Team("Barcelona", 90, 80, 85),
            new Team("Real Madrid", 92, 78, 85),
            new Team("Paris Saint-Germain", 88, 82, 85),
            new Team("Bayern Munich", 95, 85, 90),
            new Team("Liverpool", 91, 84, 88),
            new Team("Manchester City", 89, 87, 88),
            new Team("Juventus", 87, 81, 84),
            new Team("Chelsea", 86, 83, 85),
            new Team("Atletico Madrid", 85, 88, 87),
            new Team("Borussia Dortmund", 84, 76, 80),
            new Team("Manchester United", 83, 82, 83),
            new Team("Tottenham Hotspur", 82, 79, 81),
            new Team("Inter Milan", 80, 78, 79),
            new Team("AC Milan", 79, 77, 78),
            new Team("Napoli", 78, 75, 77),
            new Team("AS Roma", 77, 74, 76),
            new Team("RB Leipzig", 76, 73, 75),
            new Team("Ajax", 75, 72, 74),
            new Team("Sevilla", 74, 76, 75),
            new Team("FC Porto", 73, 70, 72),
            new Team("Benfica", 72, 69, 71),
            new Team("Olympique Lyon", 71, 68, 70),
            new Team("Shakhtar Donetsk", 70, 67, 69),
            new Team("Besiktas", 69, 66, 68),
            new Team("PSV Eindhoven", 68, 65, 67),
            new Team("Celtic", 67, 64, 66),
            new Team("Dinamo Zagreb", 66, 63, 65),
            new Team("Galatasaray", 65, 62, 64),
            new Team("Sporting CP", 200, 200, 200),
            new Team("Club Brugge", 63, 60, 62),
            new Team("CSKA Moscow", 62, 59, 61),
            new Team("Olympiacos", 61, 58, 60),
        };

        ChampionsLeague CL = new ChampionsLeague(teams);
        foreach (Group g in CL.GroupStage)
            g.GetInfo();

        CL.PlayGroupStage();

    }

    
}
