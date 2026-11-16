using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    //jump script, see bottom of code
    public float jumpForce = 10f;
    

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundMask;

    private Rigidbody2D rb2d;
    private bool isGrounded;


    //variable setup
    public float force;
    public InputAction MoveAction;
    bool canJump = true;
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collision Detected");
        if(collision.gameObject.CompareTag("Floor"))
        {
            canJump = true;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Vector2 position = (Vector2)transform.position + move * force;
        transform.position = position;
    }
}





//code taking

//jump : https://share.google/3BZGum87kF9X19je7
