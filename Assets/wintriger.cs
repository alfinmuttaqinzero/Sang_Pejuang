using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public GameObject winPanel;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("player"))
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f; // Menghentikan waktu di game
        }
    }
}

