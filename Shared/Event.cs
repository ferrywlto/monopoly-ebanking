namespace Shared;

public enum EventType 
{
    Jail,
    // A pay B for C
    // A build X (house/hotel)
    // A buy X
    // A sell X

}

// 4 Rails stations
// 2 Utilities
// 22 Streets
// 16 Community Chest
// 16 Chance
// 4 Tax
// 1 Jail
// 1 Go to Jail
// 1 Free Parking
// 1 Go

// Bank

public class Asset
{
    public string Name;
    public int Houses;
    public int Hotels;
    public int Price;
    public int Rent;
}

public class Player
{
    public string Name;
    public int Money;
    public int Position;
    

}

public class Game
{
    public List<Player> Players;
}

public class Event
{

}
