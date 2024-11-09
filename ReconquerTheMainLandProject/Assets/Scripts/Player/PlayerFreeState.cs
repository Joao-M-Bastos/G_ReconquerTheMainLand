using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFreeState : PlayerState
{
    public void FinishState(PlayerMachineController machine, PlayerController player)
    {

    }

    public void FixedUpdateState(PlayerMachineController machine, PlayerController player)
    {
        player.Walk();
    }

    public void StartState(PlayerMachineController machine, PlayerController player)
    {

    }

    public void UpdateState(PlayerMachineController machine, PlayerController player)
    {
        player.Attack();
        player.RotateCharacter();
    }
}
