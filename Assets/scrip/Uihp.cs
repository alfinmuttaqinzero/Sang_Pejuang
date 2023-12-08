using UnityEngine;
using UnityEngine.UI;

public class Uihp : MonoBehaviour
{
    public Image playerHpBar;
    public void PlayerBar(float hp)
    {
        // Mengupdate tampilan bar HP
        playerHpBar.fillAmount = hp / 100;
    }
}

