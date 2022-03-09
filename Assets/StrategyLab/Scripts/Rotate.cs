using UnityEngine;

public class Rotate : IStrategy
{
    private float _speedRotate;

    public Rotate(float speedRotate)
    {
        _speedRotate = speedRotate;
    }

    public void Perform(Transform transform)
    {
        transform.Rotate(Vector3.forward, _speedRotate * Time.deltaTime);
    }
}