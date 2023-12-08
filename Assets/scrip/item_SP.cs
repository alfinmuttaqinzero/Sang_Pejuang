using UnityEngine;

public class item_SP : MonoBehaviour
{

    public GameObject item1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "weapon")
        {
            item1.SetActive(true);
        }
    }
}

