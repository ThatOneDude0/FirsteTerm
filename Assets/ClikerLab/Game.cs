using UnityEngine;

public class Game : MonoBehaviour
{
    public GameConfig GameConfig;
    public ResourceBank ResourceBank;
    public static Game Intance;

    public void Awake()
    {
        Intance = this;
        ResourceBank.ChangeResource(GameResource.HUMANS, GameConfig.Humans);
        ResourceBank.ChangeResource(GameResource.FOOD, GameConfig.Food);
        ResourceBank.ChangeResource(GameResource.WOOD, GameConfig.Wood);
    }
}
