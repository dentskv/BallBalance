using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _fixedJoystick;
    [SerializeField] private float rotationSpeed;
    private float rotateVertical;
    private float rotateHorizontal;

    void FixedUpdate()
    {
        rotateVertical = _fixedJoystick.Vertical * rotationSpeed;
        rotateHorizontal = _fixedJoystick.Horizontal * -rotationSpeed;

        transform.Rotate(rotateVertical, 0, rotateHorizontal);

    }
}
