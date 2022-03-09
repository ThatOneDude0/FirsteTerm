using UnityEngine;

public class Emmit : IStrategy
{
    private int _count;

    public Emmit(int count)
    {
        _count = count;
    }

    public void Perform(Transform transform)
    {
        ParticleSystem particleSystem = transform.GetComponentInChildren<ParticleSystem>();
        particleSystem.Emit(_count);
    }
}
