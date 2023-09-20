using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class HealthBehavior : MonoBehaviour
{
    public float maxHealth;
    public float currentHealth;

    public UnityEvent OnDie; //Declaración del evento
    public UnityEvent<float> OnChangeHealth;

    private void OnEnable()
    {
        currentHealth = maxHealth;
        OnChangeHealth.Invoke(currentHealth);
    }

    public void Heal(float health)
    {
        currentHealth += health;
        if(currentHealth>=maxHealth)
        {
            currentHealth = maxHealth;
        }
        OnChangeHealth.Invoke(currentHealth);
    }

    public void Hurt(float damage)
    {
        currentHealth -= damage;
        if(currentHealth<=0)
        {
            //Avisar de que la vida ha llegado a cero
            OnDie.Invoke();
            currentHealth = 0;
            //GameObject asteroid1 = Instantiate(smallAsteroidPrefab, transform.position + Vector3.up, Quaternion.identity);
        }
        OnChangeHealth.Invoke(currentHealth);
    }

    public float GetHealth()
    {
        return currentHealth;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<HealthBehavior>().GetHealth();
    }
}
