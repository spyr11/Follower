using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class RigidBodyMover : MonoBehaviour, IMovable
{
    [SerializeField] private float _speed;

    private Vector3 _direction = Vector3.zero;
    private Rigidbody _rigidbody;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        Move(_direction);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move(Vector3 direction)
    {
        direction.y = 0;

        Vector3 newPosition = direction.normalized * _speed;

        newPosition.y = _rigidbody.velocity.y;

        _rigidbody.velocity = newPosition;
    }
}
