using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface PlayerState
{
    public void StartState(PlayerMachineController machine, PlayerController player);

    public void FinishState(PlayerMachineController machine, PlayerController player);

    public void UpdateState(PlayerMachineController machine, PlayerController player);

    public void FixedUpdateState(PlayerMachineController machine, PlayerController player);
}
