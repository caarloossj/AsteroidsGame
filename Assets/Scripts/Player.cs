using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private MovementBehavior mvb;
    private NewControls nc;
    public float speedRotation;

    private void OnEnable()
    {
        Vector3 postrans = Camera.main.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0.0f));
        postrans.z = 0;
        transform.position = postrans;
    }
    private void Start()
    {
        mvb = GetComponent<MovementBehavior>();
        nc = GetComponent<NewControls>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, nc.moveValue.x *speedRotation);
        mvb.Move(nc.moveValue.y * transform.right);
        /*if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(0, 0, speedRotation);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 0, -speedRotation);
        } 
        if (Input.GetKey(KeyCode.W))
        {
            mvb.Move(transform.right);
        }
        if (Input.GetKeyDown(KeyCode.Space)) //GetKeyDown es para cuando la tecla se pulse
        {
            

            GetComponent<AudioSource>().Play();
        }*/
        //transform.position += transform.right * speedRotation * Time.deltaTime; //Transform.right  es la flecha roja (Y ya está normalizado)
    }
}
