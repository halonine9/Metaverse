using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    public float speed = 5f;
    public Vector2 min;
    public Vector2 max;
   
    Vector3 offset;
    void Start()
    {
        offset = transform.position - target.position;
    }
    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset;
        desiredPosition.z = transform.position.z;
        
        desiredPosition.x = Mathf.Clamp(desiredPosition.x, min.x, max.x);
        desiredPosition.y = Mathf.Clamp(desiredPosition.y, min.y, max.y);
        
        transform.position = Vector3.Lerp(transform.position, desiredPosition, Time.deltaTime * speed);
    }
}
