using UnityEngine;
using UnityEngine.AI;

public class NPCController : Controller
{

    public Transform target;

    private NavMeshAgent agent;
    private Animator animator;

    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();

        agent.SetDestination(target.position);
        agent.isStopped = false;

    }

    // Update is called once per frame
    void Update()
    {

        agent.SetDestination(target.position);

        if (agent.remainingDistance < 2.0f)
        {
            agent.isStopped = true;
            animator.SetFloat("velocity", 0);

        }
        else
        {
            agent.isStopped = false;
            animator.SetFloat("velocity", agent.speed);

        }

        if (isAttacking && attackTime < 5.0f)
        {
            animator.SetTrigger("attack");
            attackTime += Time.deltaTime;
        }

    }
}
