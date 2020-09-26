using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSpeed : PowerUp
{
    [SerializeField]
    PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = SpawnPowerup.instance.playerMovement;
    }
    public override void Use()
    {
        playerMovement.speed += value;
        base.Use();
    }

    public override void AfterCount()
    {
        playerMovement.speed -= value;
    }
}
