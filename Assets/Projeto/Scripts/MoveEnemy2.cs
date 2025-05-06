using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;

public class MoveEnemy2 : MonoBehaviour
{
    NavMeshAgent _agent;
    [SerializeField] Transform _alvo;

    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();  
    }

   
    void Update()
    {
        _agent.destination = _alvo.position;
    }
}
