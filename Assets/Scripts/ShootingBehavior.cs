using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingBehavior : MonoBehaviour
{
    public GameObject bulletPrefab;
    private bool doubleShot = false;
    public float timeToDoubleShot;

    public void Start()
    {
        doubleShot = false;
    }
    public void Shoot()
    {
        if (!doubleShot)
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity);
            bullet.GetComponent<Bullet>().SetDirection(transform.right);
        }
        else
        {
            GameObject bullet1 = Instantiate(bulletPrefab, transform.position + new Vector3(0.2f, 0f, 0f), Quaternion.identity);
            bullet1.GetComponent<Bullet>().SetDirection(transform.right);

            GameObject bullet2 = Instantiate(bulletPrefab, transform.position - new Vector3(0.3f, 0f, 0f), Quaternion.identity);
            bullet2.GetComponent<Bullet>().SetDirection(transform.right);
        }
    }
    public void StartDoubleShot()
    {

        doubleShot = true;


        Invoke("StopDoubleShot", timeToDoubleShot);
    }

    private void StopDoubleShot()
    {
        doubleShot = false;
    }
}

