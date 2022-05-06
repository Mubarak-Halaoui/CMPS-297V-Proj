using UnityEngine;
using UnityEngine.AI;
public class Mummy : MonoBehaviour
{
    NavMeshAgent _navMeshAgent;
    void Awake()
    {
        _navMeshAgent = GetComponent<NavMeshAgent>();
    }
    // Update is called once per frame
    void Update()
    {
        var player = FindObjectOfType<PlayerMovement>();
        _navMeshAgent.SetDestination(player.transform.position);
    }
}
