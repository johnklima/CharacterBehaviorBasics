using UnityEngine;

public class PlayerController : Controller
{
   
    public float horizontalInput = 1.0f;
    public float verticalInput = 1.0f;
    
    private float xRotation = 0f;
    public float mouseSensitivity = 01.0f;
    public Transform playerCamera;

    public float moveSpeed = 4.0f;

    private Rigidbody body;
    private Animator animator;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        body = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log(body.linearVelocity);

        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        transform.Rotate(Vector3.up * mouseX);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        horizontalInput = Input.GetAxis("Horizontal") * moveSpeed;
        verticalInput = Input.GetAxis("Vertical") * moveSpeed;

        transform.Translate(Vector3.forward * verticalInput * Time.deltaTime);
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime);

        float speed = (verticalInput * Time.deltaTime + horizontalInput * Time.deltaTime) / 2;
        animator.SetFloat("velocity", speed * 10.0f);


        if(isAttacking && attackTime < 5.0f)
        {
            animator.SetTrigger("attack");
            attackTime += Time.deltaTime;
        }
    }


}
