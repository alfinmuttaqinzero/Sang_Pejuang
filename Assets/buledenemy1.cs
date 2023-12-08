using UnityEngine;

public class BulletEnemy1 : MonoBehaviour
{
    public float speed = 5f; // Kecepatan peluru

    private void Start()
    {
        // Menghancurkan objek setelah beberapa detik (opsional)
        Destroy(gameObject, 3f);
    }

    private void Update()
    {
        // Meluncurkan objek ke depan sesuai dengan arah rotasinya
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Menyentuh objek dengan tag "Environment" atau "Player"
        if (other.CompareTag("environment") || other.CompareTag("player"))
        {
            // Hancurkan objek saat menyentuh environment atau player
            Destroy(gameObject);
        }
    }
}

