using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float movSpeed;
    public float dashSpeed;
    public float dashDuration = 0.5f; // Duration of the dash in seconds
    private float dashTimeLeft = 0f; // Time left for the current dash
    private bool isDashing = false; // Flag to check if dashing
    public float dashCooldown = 2f; // Cooldown time between consecutive dashes
    private float dashCooldownTimer = 0f; // Timer for dash cooldown

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxisRaw("Horizontal");
        float verticalInput = Input.GetAxisRaw("Vertical");

        // Check if the player can dash and if the dash button is pressed
        if (Input.GetKeyDown(KeyCode.Space) && !isDashing && dashCooldownTimer <= 0f)
        {
            // Start dashing
            isDashing = true;
            dashTimeLeft = dashDuration;
            dashCooldownTimer = dashCooldown;
        }

        if (isDashing)
        {
            // While dashing, move at the dash speed
            rb.velocity = new Vector2(horizontalInput * dashSpeed, verticalInput * dashSpeed);

            // Reduce the remaining dash time
            dashTimeLeft -= Time.deltaTime;

            // Check if the dash duration has ended
            if (dashTimeLeft <= 0)
            {
                isDashing = false;
                rb.velocity = Vector2.zero; // Stop dashing
            }
        }
        else
        {
            // If not dashing, move at the regular speed
            rb.velocity = new Vector2(horizontalInput * movSpeed, verticalInput * movSpeed);
        }

        // Reduce the dash cooldown timer
        if (dashCooldownTimer > 0f)
        {
            dashCooldownTimer -= Time.deltaTime;
        }
    }
}

