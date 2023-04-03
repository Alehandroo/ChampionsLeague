public class Team
{
    public string TeamName { get; set; }
    public int AttkRating { get; set; }
    public int DefenseRating { get; set; }
    public int Luck { get; set; }
    
    public int points { get; set; }
    public Team(string TeamName, int AttkRating, int DefenseRating, int Luck, int points)
    {
        this.TeamName = TeamName;
        this.AttkRating = AttkRating;
        this.DefenseRating = DefenseRating;
        this.Luck = Luck;
    }
}



