using System;

public class Match
{
    private Team HomeTeam;
    private Team AwayTeam;
    private readonly Random random;

    public Match(Team homeTeam, Team awayTeam)
    {
        this.HomeTeam = homeTeam;
        this.AwayTeam = awayTeam;
        this.random = new Random();
    }



    public void SimulateMatch()
    {

        Console.WriteLine($"Início da partida: {HomeTeam.TeamName} x {AwayTeam.TeamName}");
        Console.WriteLine();

        int homeGoals = 0;
        int awayGoals = 0;

        // Simula os 90 minutos da partida
        for (int minute = 1; minute <= 90; minute++)
        {
            bool homeTeamScored = false;
            bool awayTeamScored = false;

            // Gera uma chance de gol para cada equipe a cada minuto
            homeTeamScored = GenerateGoalChance(HomeTeam.AttkRating, AwayTeam.DefenseRating);
            awayTeamScored = GenerateGoalChance(AwayTeam.AttkRating, HomeTeam.DefenseRating);

            // Se alguma equipe marcou gol, incrementa o placar
            if (homeTeamScored)
            {
                Console.WriteLine($"Gol do {HomeTeam.TeamName}! ({minute} minutos)");
                homeGoals++;
            }

            if (awayTeamScored)
            {
                Console.WriteLine($"Gol do {AwayTeam.TeamName}! ({minute} minutos)");
                awayGoals++;
            }
        }

        Console.WriteLine();
        Console.WriteLine($"Fim de jogo: {HomeTeam.TeamName} {homeGoals} x {awayGoals} {AwayTeam.TeamName}");

        if (awayGoals > homeGoals)
        {
            AwayTeam.
        }
    }

    private bool GenerateGoalChance(int attackStrength, int defenseStrength)
    {
        int maxChance = 100;
        int chance = random.Next(maxChance);

        // Calcula a chance de gol com base na diferença de força entre ataque e defesa
        int diff = attackStrength - defenseStrength;
        if (diff > 0)
        {
            chance += diff;
        }

        return chance >= 99;
    }
}