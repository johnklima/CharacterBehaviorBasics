using FMODUnity;
using UnityEngine;

public class FmodController : MonoBehaviour
{

    private StudioEventEmitter emitter;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        emitter = GetComponent<StudioEventEmitter>();
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
