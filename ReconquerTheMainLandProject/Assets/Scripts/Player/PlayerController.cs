using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour, IDamageable
{
    #region Values
    [SerializeField] CharacterData _playerData;

    int _currentLife;
    #endregion

    #region References
    [SerializeField] SpriteRenderer _playerSprite;
    Rigidbody2D _playerRB;
    PlayerInput _playerInput;

    InputAction _walkAction;
    InputAction _fireAction;

    Camera _mainCamera;

    [SerializeField] Shoulder _shoulder;
    [SerializeField] RightHand _rightHand;
    #endregion

    private void Awake()
    {
        _playerRB = GetComponent<Rigidbody2D>();

        _mainCamera =Camera.main;

        _playerInput = GetComponent<PlayerInput>();
        _walkAction = _playerInput.actions.FindAction("Move");
        _fireAction = _playerInput.actions.FindAction("Fire");
    }

    private void Start()
    {
        _currentLife = _playerData.MaxLife;
    }

    #region Actions

    public void Walk()
    {
        Vector2 inputDirection = _walkAction.ReadValue<Vector2>().normalized;

        Vector2 velocity = _playerRB.velocity;

        //Desaceleration
        if (inputDirection == Vector2.zero)
        {
            velocity.x = Mathf.Lerp(velocity.x, 0, _playerData.Aceleration * 4);
            velocity.y = Mathf.Lerp(velocity.y, 0, _playerData.Aceleration * 4);
        }
        else
        {
            velocity.x = Mathf.Lerp(velocity.x, inputDirection.x * _playerData.Speed, _playerData.Aceleration);
            velocity.y = Mathf.Lerp(velocity.y, inputDirection.y * _playerData.Speed, _playerData.Aceleration);
        }

        _playerRB.velocity = velocity;
    }

    public void RotateCharacter()
    {
        if(_mainCamera.ScreenToWorldPoint(Input.mousePosition).x > transform.position.x)
            _playerSprite.flipX = false;
        else
            _playerSprite.flipX = true;
    }

    public void Attack()
    {
        if (_fireAction.WasPerformedThisFrame() && _shoulder.CanAttack)
        {
            _rightHand.Attack(out float attackSpeed);
            _shoulder.Attack(attackSpeed);
            
        }
    }
    #endregion

    #region Verifications

    #endregion

    #region Calculations

    public void TakeDamage(int damage)
    {
        _currentLife -= damage;
    }

    public void TakeKnockback()
    {

    }

    #endregion
}
