using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class ResourceBank : MonoBehaviour
{
    Dictionary<GameResource, int> resources;

    private void OnEnable()
    {
        resources = new Dictionary<GameResource, int>()
        {
            [GameResource.HUMANS] = Game.Intance.GameConfig.Humans,
            [GameResource.FOOD] = Game.Intance.GameConfig.Food,
            [GameResource.WOOD] = Game.Intance.GameConfig.Wood,
            [GameResource.STONE] = Game.Intance.GameConfig.Stone,
            [GameResource.GOLD] = Game.Intance.GameConfig.Gold
        };
    }

    public void ChangeResource(GameResource r, int v)
    {
        if (!resources.ContainsKey(r))
        {
            throw new InvalidDataException();
        }

        resources[r] += v;
    }

    public int GetResource(GameResource r)
    {
        if (!resources.ContainsKey(r))
        {
            throw new InvalidDataException();
        }

        return resources[r];

    }

}
