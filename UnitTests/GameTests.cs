using Shared;

namespace UnitTests;

public class GameTests 
{
    [Fact]
    public void PlayerCountShouldIncreaseOneAfterAddPlayer() 
    {
        var game = new Game();
        var player = new Player();
        game.AddPlayer(player);
        Assert.Single(game.Players);
    }

    [Fact]
    public void PlayerCountShouldDeceraseOneAfterRemovePlayer() 
    {
        var game = new Game();
        var player = new Player();
        game.AddPlayer(player);
        game.RemovePlayer(player);
        Assert.Empty(game.Players);
    }

    [Fact]
    public void ShouldThrowExceptionWhenStartGameWithLessThanTwoPlayers() 
    {
        var game = new Game();
        var player = new Player();
        game.AddPlayer(player);
        Assert.Throws<Exception>(() => game.Start());
    }

    [Fact]
    public void PlayerCountShouldRemainSameAfterShuffle() 
    {
        var game = new Game() {
            Players = 
            [
                new() { Name = "Ferry"},
                new() { Name = "Elaine"},
                new() { Name = "Kang"},
                new() { Name = "Chelsea"},
            ]
        };
        game.Start();
        Assert.Equal(4, game.Players.Count);
    }
}