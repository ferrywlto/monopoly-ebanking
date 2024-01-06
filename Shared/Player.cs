namespace Shared;

public class Player
{
    public string Name = "";
    public int Money = 1250;
    
    public void Pay(int amount, Player to)
    {
        Money -= amount;
        to.Money += amount;
    }
}
