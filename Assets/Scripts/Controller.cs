using UnityEngine;

public class Controller : MonoBehaviour
{

    protected bool isAttacking = false;
    protected float attackTime = 0;
    protected Animator animator;


    public void Attack()
    {
        Debug.Log("ATTACK");
        isAttacking = true;
        attackTime = 0;
    }
    public void UpdateAttack()
    {
        
        if (isAttacking && attackTime < 5.0f)
        {
            animator.SetTrigger("attack");
            attackTime += Time.deltaTime;
        }
    }
}
