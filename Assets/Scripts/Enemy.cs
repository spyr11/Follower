using UnityEngine;

public class Enemy : Character
{
    [SerializeField] private Transform _target;

    private float _distanceToStop = 2f;

    protected override Vector3 GetDirection()
    {
        Vector3 direction = _target.position - transform.position;
        transform.rotation = Quaternion.LookRotation(direction);

        if (Vector3.SqrMagnitude(direction) < (_distanceToStop * _distanceToStop))
        {
            return Vector3.zero;
        }

        return transform.forward;
    }
}
