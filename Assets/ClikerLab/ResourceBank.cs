using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ResourceBank : MonoBehaviour
{
    private Dictionary<GameResource, int> _resources;

    private void OnEnable()
    {
        _resources = new Dictionary<GameResource, int>()
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
        v = Game.Intance.GameConfig.Value;
        if (!_resources.ContainsKey(r))
        {
            throw new InvalidDataException();
        } 
        _resources[r] += v;
    }

    public int GetResource(GameResource r)
    {
        return _resources[r];
    }
}
