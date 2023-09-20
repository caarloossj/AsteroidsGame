using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBehavior : MonoBehaviour
{
    public float damage;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<HealthBehavior>().Hurt(damage);
    }
}
