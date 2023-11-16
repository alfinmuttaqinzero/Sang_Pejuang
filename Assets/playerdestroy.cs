using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision Detected");
        if (other.gameObject.CompareTag("enemy1"))
        {
            // Hancurkan objek ini
            Destroy(other.gameObject);
        }
    }
}

