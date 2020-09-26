using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heal : PowerUp
{
    [SerializeField]
    PlayerHealth playerHealth;

    private void Start()
    {
        playerHealth = SpawnPowerup.instance.playerHealth;
    }

    public override void Use()
    {
        int health = playerHealth.currentHealth + value;

        //if duration
        if (health > playerHealth.startingHealth)
            value -= (health - playerHealth.startingHealth);
        
        playerHealth.currentHealth = Mathf.Clamp(health, 0, playerHealth.startingHealth);
        playerHealth.UpdateSlider();
        
        base.Use();
    }

    public override void AfterCount()
    {
        playerHealth.currentHealth -= value;
        playerHealth.UpdateSlider();
    }
}