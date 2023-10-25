using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{


    public int maxHealth = 15;
    public int minHealth = 0;
    public int currentHealth;

    public HealthBar healthBar;
           
    
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxhealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(1);
        }
    }

    void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);
    }
}
