using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
   public Transform target; 
   public float smoothSpeed = 0.125f; 

    public Vector3 offset;

    public Vector3 minPosition; 
    public Vector3 maxPosition;

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; 
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); 
        transform.position = new Vector3(smoothedPosition.x, smoothedPosition.y, transform.position.z);
    }

}