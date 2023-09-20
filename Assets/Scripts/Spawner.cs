using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    private float timer;
    public float limit;
    public GameObject player;

    public UnityEvent OnMaxAsteroids;

    public float maxAsteroids;

    private bool active;
    private void Start()
    {
        timer = 0;
        active = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        if(active)
        {
            Vector3 dir;
            timer = timer + Time.deltaTime;
            if (timer > limit)
            {
                GameObject asteroid = Instantiate(asteroidPrefab, transform.position, Quaternion.identity);
                if (player != null)
                    dir = player.transform.position - asteroid.transform.position;
                else
                    dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0f);

                asteroid.GetComponent<Asteroid>().SetDirection(dir);

                timer = 0;
            }
            //OnMaxAsteroids.Invoke(maxAsteroids);
        }
    }

    public void StopSpawner()
    {
        active = false;
    }

    public void StartSpawner()
    {
        active = true;
    }
}