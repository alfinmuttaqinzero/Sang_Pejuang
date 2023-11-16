using UnityEngine;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    public Text pointText;
    public void Setup (int score)
    {
        gameObject.SetActive (true);
        pointText.text = score.ToString () + "Score";
    }
}
