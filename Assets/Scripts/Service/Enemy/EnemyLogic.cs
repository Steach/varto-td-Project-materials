
using UnityEngine;
using UnityEngine.AI;

public class EnemyLogic : MonoBehaviour
{
    [SerializeField] private NavMeshAgent navAgent;
    [SerializeField] private int currentHp;

    public void MoveTo(Transform destination)
    {
        navAgent.SetDestination(destination.position);
    }
}