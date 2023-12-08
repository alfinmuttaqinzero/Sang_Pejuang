using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafolow : MonoBehaviour
{
    public Transform playerPos;
    public Vector3 offset;
    public float cameraspeed;

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, playerPos.position + offset, cameraspeed * Time.deltaTime);
    }
}
