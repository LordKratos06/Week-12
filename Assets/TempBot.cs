
using UnityEngine;
using UnityEngine.AI;

public class TempBot : MonoBehaviour
{
    [SerializeField] NavMeshAgent agent;
    [SerializeField] Transform target;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        if (distanceToTarget < 2)
            agent.isStopped = true;

        if (distanceToTarget > 4)
            agent.isStopped = false;
    }
}
