using UnityEngine;
using UnityEngine.UIElements;

public class enemyController : MonoBehaviour
{
    public Vector2 move;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!collision.collider.CompareTag("Floor"))
        {
            move = -move;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = (Vector2)transform.position + move;
        transform.position = position;
    }
}
