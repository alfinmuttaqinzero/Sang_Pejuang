using System.Collections;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyPrefab;

    [SerializeField]
    private Vector3 spawnPosition; // Posisi spawn yang diinginkan

    void Start()
    {
        StartCoroutine(SpawnEnemyRandomly());
    }

    private IEnumerator SpawnEnemyRandomly()
    {
        while (true)
        {
            // Waktu random antara 1 hingga 5 detik
            float spawnInterval = Random.Range(1f, 5f);

            // Tunggu selama waktu random sebelum memanggil lagi
            yield return new WaitForSeconds(spawnInterval);

            // Instantiate objek enemy di posisi yang diinginkan
            Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);
        }
    }
}