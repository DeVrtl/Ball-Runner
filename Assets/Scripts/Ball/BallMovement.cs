using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BallMovement : MonoBehaviour
{
    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;
    [SerializeField] private float _raycastDistance;

    private Rigidbody _rigidbody;
    private float _horizontalMovement;
    private float _verticalMovement;

    private void OnValidate()
    {
        _speed = Mathf.Clamp(_speed, 0, float.MaxValue);
        _jumpForce = Mathf.Clamp(_jumpForce, 0, float.MaxValue);
        _raycastDistance = Mathf.Clamp(_raycastDistance, 0, float.MaxValue);
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _rigidbody.AddForce(_speed * Time.deltaTime * new Vector3(_horizontalMovement, 0, _verticalMovement));

        if (GroundCheck() && Input.GetKeyDown(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector3.up * _jumpForce);
        }
    }

    private void Update()
    {
        ProcessInputs();
    }

    private bool GroundCheck()
    {
        return Physics.Raycast(transform.position, Vector3.down, _raycastDistance);
    }

    private void ProcessInputs()
    {
        _horizontalMovement = Input.GetAxis(Horizontal);
        _verticalMovement = Input.GetAxis(Vertical);
    }
}
