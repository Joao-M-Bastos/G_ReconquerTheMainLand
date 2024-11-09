using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shoulder : MonoBehaviour
{
    Camera _cameraMain;
    Animator _shoulderAnimator;

    float _attackCooldown;
    bool _canAttack;

    public bool CanAttack => _canAttack;

    private void Awake()
    {
        _shoulderAnimator = GetComponent<Animator>();
        _cameraMain = Camera.main;
    }

    public void Attack(float attackSpeed)
    {
        _shoulderAnimator.SetFloat("AttackSpeed", attackSpeed);
        _shoulderAnimator.SetTrigger("Attack");

        _attackCooldown = 1/attackSpeed;
    }

    private void Update()
    {
        _attackCooldown -= Time.deltaTime;
        _canAttack = _attackCooldown < 0;

        RotateToMouse();
    }

    private void RotateToMouse()
    {
        Vector3 mouse_pos = _cameraMain.ScreenToWorldPoint(Input.mousePosition);
        mouse_pos.z = 10f; //The distance between the camera and object
        Vector3 object_pos = this.transform.position;
        mouse_pos.x = mouse_pos.x - object_pos.x;
        mouse_pos.y = mouse_pos.y - object_pos.y;
        float angle = Mathf.Atan2(mouse_pos.y, mouse_pos.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));
    }
}
