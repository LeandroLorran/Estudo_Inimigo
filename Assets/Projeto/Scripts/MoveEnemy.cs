using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy : MonoBehaviour
{

    NavMeshAgent _agent;

    public Transform _Player;
    
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
    }

   
    void Update()
    {
        _agent.SetDestination(_Player.position);
    }
}
