using UnityEngine;

public class EnemyAIMove : MonoBehaviour
{
    public float detectionRadius = 5f; // Jari-jari lingkaran deteksi
    public GameObject player;
    public float speedE;
    public float distanceStop;

    private void Update()
    {
        float distance = Vector2.Distance(transform.position, player.transform.position);

        // Periksa apakah player berada dalam jarak deteksi
        if (distance < detectionRadius)
        {
            // Periksa apakah jarak antara enemy dan player lebih besar dari stopDistance
            if (distance > distanceStop)
            {
                // Menggerakkan enemy ke arah player
                transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speedE * Time.deltaTime);

                // Mengatur rotasi agar enemy selalu menghadap ke arah player
                Vector2 direction = player.transform.position - transform.position;
                float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
            }
        }

    }
}

