using UnityEngine;

public class Controller : MonoBehaviour
{

    protected bool isAttacking = false;
    protected float attackTime = 0;

    public void Attack()
    {
        Debug.Log("ATTACK");
        isAttacking = true;
        attackTime = 0;
    }
}
