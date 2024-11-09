using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoulder : MonoBehaviour
{
    Camera _cameraMain;
    Animator _shoulderAnimator;

    private void Awake()
    {
        _shoulderAnimator = GetComponent<Animator>();
        _cameraMain = Camera.main;
    }

    public void Attack()
    {
        _shoulderAnimator.SetTrigger("Attack");
    }

    private void Update()
    {
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
