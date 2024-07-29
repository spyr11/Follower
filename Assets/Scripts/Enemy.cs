using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private Transform _target;
    [SerializeField] private float _movementSpeed;

    private float _distanceToStop = 2f;

    private void FixedUpdate()
    {
        Vector3 direction = _target.position - transform.position;

        Move(direction);
    }

    private void Move(Vector3 direction)
    {
        if (Vector3.SqrMagnitude(direction) < _distanceToStop * _distanceToStop)
        {
            _rigidbody.velocity = Vector3.zero;

            return;
        }

        _rigidbody.rotation = Quaternion.LookRotation(direction);

        Vector3 newPosition = transform.forward * _movementSpeed;

        newPosition.y = _rigidbody.velocity.y;

        _rigidbody.velocity = newPosition;
    }
}
