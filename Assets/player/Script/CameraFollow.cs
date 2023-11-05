using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;    // The player GameObject to follow
    public Vector3 offset;      // Offset from the target position
    public float smoothing = 5.0f;  // Smoothing factor for camera movement

    private void LateUpdate()
    {
        if (target != null)
        {
            // Calculate the target position with the offset
            Vector3 targetPosition = target.position + offset;

            // Set the Z position to -10 and use lerp to smoothly move the camera towards the target position
            targetPosition.z = -10;
            transform.position = Vector3.Lerp(transform.position, targetPosition, smoothing * Time.deltaTime);
        }
    }
}
