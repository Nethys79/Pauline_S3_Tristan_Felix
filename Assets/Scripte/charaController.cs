using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charaController : MonoBehaviour
{
    [SerializeField] private GameObject _gameobject;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private FixedJoystick _joystick;

    public float _moveSpeed;

    void Start()
    {
        _gameobject = GameObject.Find("Player");
        //_joystick = Joystick.GameObject.Find("Fixed Joystick Left");
        _rigidBody = _gameobject.GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidBody.velocity = new Vector3(_joystick.Horizontal * _moveSpeed, _rigidBody.velocity.y, _joystick.Vertical * _moveSpeed);
    }
}
