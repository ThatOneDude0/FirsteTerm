using UnityEngine;

public class Performer : MonoBehaviour
{
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }
    private void Update()
    {
        _strategy?.Perform(transform);
    }
}
