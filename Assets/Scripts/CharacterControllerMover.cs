using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class CharacterControllerMover : MonoBehaviour, IMovable
{
    [SerializeField] private float _speed;

    private CharacterController _characterController;
    private Vector3 _direction = Vector3.zero;
    private float _gravity = -9.8f;

    private void Awake()
    {
        _characterController = GetComponent<CharacterController>();
    }

    private void Update()
    {
        Move(_direction);
    }

    public void SetDirection(Vector3 direction)
    {
        _direction = direction;
    }

    private void Move(Vector3 direction)
    {
        direction *= _speed;
        direction = Vector3.ClampMagnitude(direction, _speed);
        direction.y = _gravity;
        direction *= Time.deltaTime;

        _characterController.Move(direction);
    }
}