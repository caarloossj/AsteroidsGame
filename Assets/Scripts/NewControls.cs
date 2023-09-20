using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewControls : MonoBehaviour
{
    private InputPlayerActions ipa;
    //public GameObject bulletPrefab;
    //public float speedRotation;
    public Vector2 moveValue;

    private void Awake()
    {
        ipa = new InputPlayerActions();
        ipa.Player.Shoot.started += OnShoot; // += Significa que se ejecuta
        ipa.Player.Move2.canceled += OnStopMove;
        ipa.Player.Move2.performed += OnMove2;
    }

    private void OnShoot(InputAction.CallbackContext c)
    {
        GetComponent<ShootingBehavior>().Shoot();
    }

    private void OnStopMove(InputAction.CallbackContext c)
    {
        moveValue = Vector2.zero;
    }

    private void OnMove2(InputAction.CallbackContext c)
    {
        moveValue = c.ReadValue<Vector2> ();
    }

    private void OnEnable()
    {
        ipa.Enable();
    }

    private void OnDisable()
    {
        ipa.Disable();
    }
}
