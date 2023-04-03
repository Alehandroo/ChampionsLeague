
using System.Text.RegularExpressions;

public class ChampionsLeague
{
    public List<Team> Teams;
    public List<Group> GroupStage;
    public KnockOut KnockOutStage;
    public Draw Draw;

    public ChampionsLeague(List<Team> teams)
    {
        this.Teams = teams;
        Draw = new Draw(teams);
        GroupStage = Draw.GenerateGroupStage();
    }

    public void PlayGroupStage()
    {
        foreach (Group g in GroupStage)
        {
            for (int i = 0; i < GroupStage.Count - 1; i++)
            {
                for (int j = i + 1; j < g.Teams.Count; j++)
                {
                    var homeTeam = g.Teams[i];
                    var awayTeam = g.Teams[j];
                    var match = new Match(homeTeam, awayTeam);

                    Console.WriteLine();
                    Console.WriteLine($"Partida 1: {homeTeam.TeamName} (casa) x {awayTeam.TeamName} (fora)");
                    match.SimulateMatch();
                }
            }

        }
    }

    public void PlayKnockOutStage()
    {

    }
}