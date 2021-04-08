using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target;
    public float smoothTime = 0.3F;
    private Vector2 currentVelocity = Vector2.zero;
    private Vector2 positionXY;
    void FixedUpdate()
    {
        if (target.transform.position.x > transform.position.x + 2 || target.transform.position.x < transform.position.x - 2 || target.transform.position.y > transform.position.y + 2 || target.transform.position.y < transform.position.y - 2)
        {
            positionXY = Vector2.SmoothDamp(transform.position, target.transform.position, ref currentVelocity, smoothTime);
            transform.position = new Vector3(positionXY.x, positionXY.y + 0.025F, -10);
        }
    }
}
