using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kit : MonoBehaviour
{
    private MovementBehavior mvb;
    private HealthBehavior healthBehaviour;
    Vector3 dir;
    // Start is called before the first frame update
    private void Start()
    {
        //dir = new Vector3(Random.Range(-1.0f, 1.0f), Random.Range(-1.0f, 1.0f), 0f);
        //dir.Normalize(); //Normalizar significa ajustar el vector a 1 para que por ejemplo en este caso, mantenga la velocidad en todos los ateroides igual.

        mvb = GetComponent<MovementBehavior>();
        
        GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
        if (playerObject != null) 
        {
            healthBehaviour = playerObject.GetComponent<HealthBehavior>();
        }
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

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            healthBehaviour.Heal(healthBehaviour.maxHealth);

            Destroy(gameObject);
        }
    }
}

