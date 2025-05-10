using Unity.AI.Navigation;
using UnityEngine;
using UnityEngine.AI;
using static UnityEditor.PlayerSettings;

public class MoveEnemy2 : MonoBehaviour
{
    NavMeshAgent _agent;
    Transform _alvo;
    GameControlle _gc;


    void Start()
    {
        _gc = Camera.main.GetComponent<GameControlle>();                                                          
        _agent = GetComponent<NavMeshAgent>();
        _alvo = _gc._player;
        
    }

   
    void Update()
    {
        _agent.destination = _alvo.position;
    }

    public void ResetInimigo(Vector3 pos) 
    {
        transform.position = pos;
    }

    private void OnTriggerEnter(Collider collision)
    {
         if (collision.gameObject.layer == 3)
        {
            Debug.Log("Tocou no player! ");
            //ResetInimigo(_positionStart);
            gameObject.SetActive(false);
        }
    }
}
