using UnityEngine;
using UnityEngine.UI;

public class ItemUse_SP : MonoBehaviour
{
    public GameObject[] uiObjects; // Pastikan UI Unity 2D di-assign ke sini di Inspector.

    void Update()
    {
        // Loop melalui array uiObjects
        for (int i = 0; i < uiObjects.Length; i++)
        {
            // Mengubah nilai UI menjadi false jika tombol 1 hingga 5 ditekan
            if (Input.GetKeyDown(KeyCode.Alpha1 + i) && i < uiObjects.Length)
            {
                uiObjects[i].SetActive(false);
            }
        }
    }
}


