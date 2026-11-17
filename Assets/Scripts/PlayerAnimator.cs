using UnityEngine;

public class PlayerAnimator : MonoBehaviour
{
    public Animator animate;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        animate.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
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
    }
}
