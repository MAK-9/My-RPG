using System;
using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    private ControlsManager controls;
    public int maxHealth = 100;
    public int currentHealth { get; private set; }
    
    public Stat damage;
    public Stat armor;

    private void Awake()
    {
        controls = GameObject.Find("ControlsManager").GetComponent<ControlsManager>();
        currentHealth = maxHealth;
    }

    private void Update()
    {
        if (controls.TestKeyToggled())
        {
            takeDamage(10);
        }
    }

    public void takeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);
        
        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage.");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        // die in some way
        // this method is meant to be overwritten
        Debug.Log(transform.name + " died.");
    }
}
