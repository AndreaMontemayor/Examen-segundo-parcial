using UnityEngine;
using UnityEngine.AI;

public class EnemyCtrl : MonoBehaviour
{
    private NavMeshAgent _navMeshAgent;

    public Transform player;
    private NavMeshAgent navMeshAgent;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        navMeshAgent = gameObject.GetComponent<NavMeshAgent>();
      
    }

    // Update is called once per frame
    void Update()
    {
      navMeshAgent.SetDestination(player.position);  
    }
}


