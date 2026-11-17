using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private bool dead = false;
    public int health = 3;
    //variable setup
    public float force;
    public InputAction MoveAction;

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
            SceneManager.LoadScene(1);
        }
        
    }
}





//code taking

//jump : https://share.google/3BZGum87kF9X19je7
