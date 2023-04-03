public class Group
{
    public string GroupName;
    public Dictionary<int,Team> Teams;
    public List<Match> Matches;

    public Group(string name, Dictionary<int,Team> teams)
    {
        GroupName = name;
        Teams = teams;
    }

    public void GetInfo()
    {
        foreach(var t in Teams)
            Console.WriteLine(t.Value.TeamName);
        Console.WriteLine();
    }
}
