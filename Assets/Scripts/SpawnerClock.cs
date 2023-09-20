using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerClock : MonoBehaviour
{
    public GameObject clockPrefab;
    private float timer;
    public float limit;
    public GameObject player;

    private bool active;
    private void Start()
    {
        timer = 0;
        active = true;
    }

    // Update is called once per frame
    void Update()
    {

        if (active)
        {
            Vector3 dir;
            timer = timer + Time.deltaTime;
            if (timer > limit)
            {
                GameObject clock = Instantiate(clockPrefab, transform.position, Quaternion.identity);
                if (player != null)
                    dir = player.transform.position - clock.transform.position;
                else
                    dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0f);

                clock.GetComponent<Clock>().SetDirection(dir);

                timer = 0;
            }
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