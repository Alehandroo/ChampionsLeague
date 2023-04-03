
public class Draw
{
    List<Team> Teams;
    public Draw(List<Team> teams)
    {
        Teams = teams;
    }
    public List<Group> GenerateGroupStage()
    {
        var random = new Random();
        List<Group> groups = new List<Group>();

        // Shuffle the list of teams randomly
        var shuffledTeams = new List<Team>(Teams);
        for (int i = shuffledTeams.Count - 1; i > 0; i--)
        {
            int j = random.Next(i + 1);
            var temp = shuffledTeams[i];
            shuffledTeams[i] = shuffledTeams[j];
            shuffledTeams[j] = temp;
        }

        // Divide the teams into groups of 4
        for (int i = 0; i < 8; i++)
        {
            var teams = new List<Team>();
            List<Team> groupTeams = new List<Team>();
            for (int j = 0; j < 4; j++)
            {
                groupTeams.Add(shuffledTeams[i * 4 + j]);
            }
            Group group = new Group("A", groupTeams);
            groups.Add(group);
        }

        return groups;
    }
    public void GenerateKnockOutStage()
    {
    }
}

