using UnityEngine;

public class MoveForward : IStrategy
{
    private float _speed;

    public MoveForward(float speed)
    {
       _speed = speed;
    }

    public void Perform(Transform transform)
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);       
    }
}
