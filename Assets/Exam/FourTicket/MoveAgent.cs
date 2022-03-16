using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class MoveAgent : MonoBehaviour
{
    [SerializeField] private NavMeshAgent _NavMeshAgent;  
    [SerializeField] private Transform[] points;

    private int _point = 0;

    private void Awake()
    {              
        GoToNextPoint();
    }

    void GoToNextPoint()
    {
        if (points.Length == 0)
        {
            enabled = false;
            return;
        }
        _NavMeshAgent.destination = points[_point].position;
        _point = (_point + 1) % points.Length;
    }

    private void Update()
    {
        if (!_NavMeshAgent.pathPending && _NavMeshAgent.remainingDistance < 0.5f)
        {
            GoToNextPoint();
        }

    }
}
