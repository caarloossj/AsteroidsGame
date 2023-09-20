using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBehavior : MonoBehaviour
{
    public GameObject explosionPrefab;

    public void DestroyObject()
    {
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }

        if (gameObject.tag == "LargeAsteroid")
        {
            // Create two smaller asteroids
            for (int i = 0; i < 2; i++)
            {
                GameObject asteroid = Instantiate(gameObject);
                asteroid.tag = "SmallAsteroid";
                asteroid.transform.localScale = transform.localScale / 2;
                asteroid.GetComponent<Asteroid>().SetDirection(new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0f));
            }
        }

        Destroy(gameObject);
    }

    public void DisableObject()
    {
        if (explosionPrefab != null)
        {
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
        }
        gameObject.SetActive(false);
    }
}
