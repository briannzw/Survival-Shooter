using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCommand : Command
{
    PlayerMovement playerMovement;
    float h, v;

    public MoveCommand(PlayerMovement _playerMovement, float _h, float _v)
    {
        playerMovement = _playerMovement;
        h = _h;
        v = _v;
    }

    public override void Execute()
    {
        playerMovement.Move(h, v);
        playerMovement.Animating(h, v);
    }

    public override void UnExecute()
    {
        playerMovement.Move(-h, -v);
        playerMovement.Animating(h, v);
    }
}
