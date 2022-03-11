using UnityEngine;

[CreateAssetMenu(menuName = "SO", fileName = "Game Config")]
public class GameConfig : ScriptableObject
{
    [Header("Resources")]
    public int Humans;
    public int Food;
    public int Wood;
    public int Stone;
    public int Gold;  
}