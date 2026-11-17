using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private bool dead = false;
    public int health;
    //variable setup
    public float force;
    public InputAction MoveAction;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Hurty"))
        {
            health -= 1;
            Debug.Log("Player health is");
            Debug.Log(health);
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
        if(health < 0 )
        {
            dead = true;
        }
        if (dead) 
        {
            
        }
    }
}





//code taking

//jump : https://share.google/3BZGum87kF9X19je7
