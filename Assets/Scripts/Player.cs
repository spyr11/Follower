using UnityEngine;

public class Player : Character
{
    private const string Horizontal = nameof(Horizontal);
    private const string Vertical = nameof(Vertical);

    protected override Vector3 GetDirection()
    {
        float horizontal = Input.GetAxis(Horizontal);
        float vertical = Input.GetAxis(Vertical);

        if (horizontal == 0 && vertical == 0)
        {
            return Vector3.zero;
        }

        return new Vector3(horizontal, 0, vertical);
    }
}
