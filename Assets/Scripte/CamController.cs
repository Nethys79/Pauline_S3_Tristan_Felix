using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamController : MonoBehaviour
{
    [SerializeField] private Camera _cam;
    [SerializeField] private GameObject _gameobject;
    [SerializeField] private Rigidbody _rigidBodyPlayer;
    [SerializeField] private Rigidbody _rigidBodyCam;
    [SerializeField] private FixedJoystick _joystick;

    Vector3 _EulerAngleVelocity;

    public float _moveSpeed;

    // Start is called before the first frame update
    void Start()
    {
        _gameobject = GameObject.Find("Player");
        _rigidBodyPlayer = _gameobject.GetComponent<Rigidbody>();

        _cam = Camera.main;
        _rigidBodyCam = _cam.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Quaternion deltaRotation1 = Quaternion.Euler(new Vector3(0, _joystick.Horizontal * _moveSpeed, 0) * Time.fixedDeltaTime);
        _rigidBodyPlayer.MoveRotation(_rigidBodyPlayer.rotation * deltaRotation1);

        Quaternion deltaRotation2 = Quaternion.Euler(new Vector3(_joystick.Vertical * -_moveSpeed, 0, 0) * Time.fixedDeltaTime);
        //_rigidBodyCam.MoveRotation(_rigidBodyCam.rotation * deltaRotation2);
    }
}
