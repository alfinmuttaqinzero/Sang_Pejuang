using UnityEngine;

public class EnemyAutoShoo : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    public float detectionRadius = 8f;

    private GameObject player;
    private float nextFireTime = 0f;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
    }

    private void Update()
    {
        // Jika player berada di dalam radius deteksi, mulai menembak
        if (Vector2.Distance(transform.position, player.transform.position) <= detectionRadius)
        {
            if (Time.time >= nextFireTime)
            {
                Shoot();
                nextFireTime = Time.time + 1f / fireRate; // atur waktu tembakan berikutnya
            }
        }
    }

    private void Shoot()
    {
        // Logika tembakan
        if (bulletPrefab != null && firePoint != null)
        {
            // Menggunakan firePoint.forward sebagai arah tembakan (lurus ke depan)
            Instantiate(bulletPrefab, firePoint.position, firePoint.rotation * Quaternion.Euler(0, 0, 90f));
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Gambar gizmos lingkaran deteksi pada Scene view
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, detectionRadius);
    }
}
