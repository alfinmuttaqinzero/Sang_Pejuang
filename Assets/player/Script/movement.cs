// Move.cs
using UnityEngine;

public class Move : MonoBehaviour
{
    public float movSpeed;

    private Rigidbody2D rb;
    private Animator anim;
    private string walkParameter = "run";
    private string idleParameter = "idle";
 
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");
        bool shoot = Input.GetMouseButtonDown(0); // Gunakan 0 sebagai argumen untuk tombol kiri mouse

        // Perform your movement logic here using horizontalInput and verticalInput
        // For example, move the Rigidbody based on input
        Vector2 movement = new Vector2(horizontalInput * movSpeed, verticalInput * movSpeed);
        rb.velocity = movement;

        // Update the animation triggers
        if (Mathf.Abs(horizontalInput) != 0 || Mathf.Abs(verticalInput) != 0)
        {
            anim.SetTrigger(walkParameter);
        }
        else
        {
            anim.SetTrigger(idleParameter);
        }

    }
}

