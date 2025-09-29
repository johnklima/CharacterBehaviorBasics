using UnityEngine;

public class Controller : MonoBehaviour
{


    private bool isAttacking = false;
    private float attackTime = 0;

    public Animator animator;
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
