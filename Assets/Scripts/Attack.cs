using UnityEngine;

public class Attack : MonoBehaviour
{

    public PlayerController controller;


    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "NPC")
        {
            controller.Attack();
        }
    }
}
