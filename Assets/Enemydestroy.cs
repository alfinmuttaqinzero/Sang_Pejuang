using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemydestroy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Collision Detected");
        if (other.gameObject.CompareTag("player"))
        {
            // Hancurkan objek ini
            Destroy(other.gameObject);
        }
    }
}
