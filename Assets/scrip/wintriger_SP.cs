using UnityEngine;

public class WinTrigger_SP : MonoBehaviour
{
    public GameObject winPanel;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "player")
        {
            winPanel.SetActive(true);
            Time.timeScale = 0f; // Menghentikan waktu di game
        }
    }
}

