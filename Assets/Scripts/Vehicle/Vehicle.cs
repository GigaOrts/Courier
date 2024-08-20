using UnityEngine;

[RequireComponent(typeof(PlayerInput))]
public class Vehicle : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private float _turnSpeed;

    private PlayerInput _playerInput;

    private void Awake()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        if (Input.GetKey(_playerInput.Forward))
        {
            Move(_speed);
        }
        if (Input.GetKey(_playerInput.Backward))
        {
            Move(-_speed);
        }

        if (Input.GetKey(_playerInput.Right))
        {
            Rotate(_turnSpeed);
        }
        if (Input.GetKey(_playerInput.Left))
        {
            Rotate(-_turnSpeed);
        }
    }

    private void Rotate(float speed)
    {
        transform.Rotate(speed * Time.deltaTime * Vector3.up);
    }

    private void Move(float speed)
    {
        transform.Translate(speed * Time.deltaTime * Vector3.forward);
    }
}
