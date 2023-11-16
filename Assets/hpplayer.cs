using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpplayer : MonoBehaviour
{
    [SerializeField] GameObject gameOv;
    public float playerHp;
    public Uihp PlayerHp;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "enemy1")
        {
            playerHp -= 1;
            PlayerHp.PlayerBar(playerHp);

            // Cek jika nilai playerHp kurang dari atau sama dengan 0
            if (playerHp <= 0)
            {
                // Menampilkan panel Game Over dan menghentikan waktu
                gameOv.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
