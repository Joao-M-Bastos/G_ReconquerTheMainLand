using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMachineController : MonoBehaviour
{
    private PlayerState _currentState;
    public readonly PlayerState FreeState = new PlayerFreeState();
    
    PlayerController _playerController;

    // Start is called before the first frame update
    void Start()
    {
        _playerController = GetComponent<PlayerController>();
        ChangeState(FreeState);
    }

    public void ChangeState(PlayerState newState)
    {
        _currentState?.FinishState(this, _playerController);
        
        _currentState = newState;

        _currentState?.StartState(this, _playerController);
    }


    private void FixedUpdate()
    {
        _currentState?.FixedUpdateState(this, _playerController);
    }

    // Update is called once per frame
    void Update()
    {
        _currentState?.UpdateState(this, _playerController);
    }
}
