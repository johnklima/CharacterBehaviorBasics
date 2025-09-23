using System.IO.Pipes;
using UnityEngine;

public class Attack : MonoBehaviour
{

    public Controller controller;
    public string tagText = "NPC";

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == tagText)
        {
            controller.Attack();
        }
    }
}
