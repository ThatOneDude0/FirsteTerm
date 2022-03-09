using UnityEngine;

public class InvokeStrategy : MonoBehaviour
{
    [SerializeField] private Performer _performer;
    [SerializeField] private float _speedMove;
    [SerializeField] private float _speedRotate;
    [SerializeField] private int _countEmmit;

    public void Move()
    {
        _performer.SetStrategy(new MoveForward(_speedMove));
    }

    public void Rotate()
    {
        _performer.SetStrategy(new Rotate(_speedRotate));
    }

    public void Emmit()
    {
        _performer.SetStrategy(new Emmit(_countEmmit));
    }
}
