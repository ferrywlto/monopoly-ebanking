namespace Shared;

/// <summary>
/// Represents a game of Monopoly eBanking.
/// </summary>
public class Game
{
    public List<Player> Players = [];
    public Player? CurrentPlayer;

    public void AddPlayer(Player player)
    {
        Players.Add(player);
    }

    public void RemovePlayer(Player player)
    {
        Players.Remove(player);
    }

    public void Start() 
    {
        CheckPlayerCount();
        SuffulePlayers();
        SetFirstPlayer();
    }

    private void SetFirstPlayer() 
    {
        CurrentPlayer = Players[0];
    }

    private void CheckPlayerCount() 
    {
        if (Players.Count < 2)
        {
            throw new Exception("Not enough players");
        }
    }

    private void SuffulePlayers()
    {
        var randomList = new List<Player>();
        var random = new Random();

        while(Players.Count > 0)
        {
            var p = Players[random.Next(Players.Count)];
            randomList.Add(p);
            Players.Remove(p);
        }

        Players = randomList;
    }
}
