using UnityEngine;

public class Player : MonoBehaviour
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    [SerializeField] private CharacterController _characterController;
    [SerializeField] private float _speed;

    private float _gravity = -9.8f;

    private void Update()
    {
        float horizontal = Input.GetAxis(Horizontal);
        float vertical = Input.GetAxis(Vertical);

        if (horizontal == 0 && vertical == 0 && _characterController.isGrounded)
        {
            return;
        }

        Move(new Vector3(horizontal, 0, vertical));
    }

    private void Move(Vector3 direction)
    {
        direction *= _speed;
        direction.y = _gravity;

        _characterController.Move(direction * Time.deltaTime);
    }
}
