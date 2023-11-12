using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dead : MonoBehaviour
{
    public GameObject deadMenu;
    // Start is called before the first frame update
    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
       
    }
    public void Quit()
    {
        Application.Quit();
        
    }
    public void gameOver(){
        deadMenu.SetActive(true); 
    }
}
