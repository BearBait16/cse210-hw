using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    Vector3 offset = new Vector3(1f, 1f, -10f);
    float smoothTime = 0.25f;
    Vector3 velocity = Vector3.zero;
    [SerializeField]
    private Transform target;
    void Update()
    {
        Vector3 targetPosition = target.position + offset;
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition, ref velocity, smoothTime);
    }

}

