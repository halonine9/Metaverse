using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    public LayerMask mapBoundaryLayer;

    void Start()
    {
        if (target is null)
            return;

        offset = transform.position- target.position;
    }

    void Update()
    {
        if (target is null)
            return;
        
        transform.position = target.position + offset;
    }
}
