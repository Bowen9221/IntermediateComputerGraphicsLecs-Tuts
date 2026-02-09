using UnityEngine;
using UnityEngine.AI;

public class NavMesh : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform target;


    void Start()
    {
        agent = FindAnyObjectByType<NavMeshAgent>();
    }

    void Update()
    {
        agent.destination = target.position;
    }

    
}
