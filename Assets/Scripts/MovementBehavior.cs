using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementBehavior : MonoBehaviour
{
    public float speed;

    public void Move(Vector3 direction)
    {
        transform.position += direction * speed * Time.deltaTime;
    }
}
