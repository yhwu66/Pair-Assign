using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class SpaceshipController : MonoBehaviour
{
    [SerializeField]
    SpaceshipMovementInput _spaceshipMovementInput;

    [SerializeField]
    [Range(1000f, 10000f)]
    float _thrustForce = 7500f, _pitchForce = 6000f, _rollForce = 1000f, _yawForce = 2000f;

    Rigidbody _rigidbody;

    [Range(-1f, 1f)]
    public float _thrustAmount, _pitchAmount, _rollAmount, _yawAmount = 0f;

    IMovementController MovementControlInput => _spaceshipMovementInput.MovementController;
    

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Console.Write("Mansimar", _spaceshipMovementInput);
        _thrustAmount = MovementControlInput.ThrustAmount;
        _rollAmount = MovementControlInput.RollAmount;
        _yawAmount = MovementControlInput.YawAmount;
        _pitchAmount = MovementControlInput.PitchAmount;
    }

    private void FixedUpdate()
    {
        if (!Mathf.Approximately(0f, _pitchAmount))
        {
            _rigidbody.AddTorque(transform.right * (_pitchForce * _pitchAmount * Time.fixedDeltaTime));
        }

        if (!Mathf.Approximately(0f, _rollAmount))
        {
            _rigidbody.AddTorque(transform.forward * (_rollForce * _rollAmount * Time.fixedDeltaTime));
        }

        if (!Mathf.Approximately(0f, _yawAmount))
        {
            _rigidbody.AddTorque(transform.up * (_yawAmount * _yawForce * Time.fixedDeltaTime));
        }

        if (!Mathf.Approximately(0f, _thrustAmount))
        {
            _rigidbody.AddForce(transform.forward * (_thrustForce * _thrustAmount * Time.fixedDeltaTime));
        }
    }
}
