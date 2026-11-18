using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int health = 3;
    //variable setup
    public float force;
    public InputAction MoveAction;
    public Animator animate;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Hurty")
        {
            Debug.Log("Player health is");
            health -= 1;
            Debug.Log(health);
        }
        
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MoveAction.Enable();
        animate.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        //animation
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        if (Input.GetKeyDown(KeyCode.A))
        {
            if (!spriteRenderer.flipX)
            {
                spriteRenderer.flipX = true;
            }
            animate.SetBool("Running", true);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            if (spriteRenderer.flipX)
            {
                spriteRenderer.flipX = false;
            }
            animate.SetBool("Running", true);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animate.SetBool("Running", false);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animate.SetBool("Running", false);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            animate.SetBool("Jumping", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animate.SetBool("Jumping", false);
        }

        //movement
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Vector2 position = (Vector2)transform.position + move * force;
        transform.position = position;

        //death
        if (health < 0)
        {
            SceneManager.LoadScene(3);
        } 
    }

   
}