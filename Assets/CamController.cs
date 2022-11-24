using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private GameObject _gameobject;
    [SerializeField] private Rigidbody _rigidBody;
    [SerializeField] private FixedJoystick _joystick;

    Vector3 _EulerAngleVelocity;

    public float _moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _cam = Camera.main;
        _gameobject = GameObject.Find("Player");
        _rigidBody = _gameobject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion deltaRotation = Quaternion.Euler(new Vector3(_rigidBody.velocity.x, _joystick.Horizontal * _moveSpeed, _rigidBody.velocity.z) * Time.fixedDeltaTime);
        _rigidBody.MoveRotation(_rigidBody.rotation * deltaRotation);
        //_cam.transform.rotation = Quaternion.Euler (new Vector3(transform.rotation.x + _joystick.Horizontal * _moveSpeed, transform.rotation.y, transform.rotation.z));
    }
}
