using UnityEngine;

public class Attack : MonoBehaviour
{

    public Controller controller;
    public string enemyTag;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == enemyTag)
        {
            controller.Attack();
        }
    }
}
