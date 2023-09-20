using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ovni : MonoBehaviour
{
    private MovementBehavior mvb;
    Vector3 dir;

    private void Start()
    {
        mvb = GetComponent<MovementBehavior>();
    }

    public void SetDirection(Vector3 d)
    {
        dir = d;
        dir.Normalize();
    }
    // Update is called once per frame
    void Update()
    {
        mvb.Move(dir);
    }

}