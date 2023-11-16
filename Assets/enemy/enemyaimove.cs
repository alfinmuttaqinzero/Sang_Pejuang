using System.Collections;
using UnityEngine;

public class enemyaimove : MonoBehaviour
{
    public float speed = 5f; // Kecepatan gerakan objek

    void Update()
    {
        // Cari objek player berdasarkan tag
        GameObject player = GameObject.FindGameObjectWithTag("player");

        if (player != null)
        {
            // Hitung arah ke objek player
            Vector3 direction = player.transform.position - transform.position;

            // Normalisasi vektor arah
            direction.Normalize();

            // Gerakkan objek ke arah player
            transform.position += direction * speed * Time.deltaTime;
        }
    }
}


