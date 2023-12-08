using UnityEngine;

public class uipause : MonoBehaviour
{
    [SerializeField]
    GameObject pausePanel;
    private void Update()
    {
        
    }

    public void Pause () 
    {
        pausePanel.SetActive(true);
        Time.timeScale = 0;  
    }

    public void Continue ()
    {
        pausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
