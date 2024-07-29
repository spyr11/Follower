using UnityEngine;

[RequireComponent(typeof(IMovable))]
public abstract class Character : MonoBehaviour
{
    private IMovable _movable;

    private void Awake()
    {
        _movable = GetComponent<IMovable>();
    }

    private void Update()
    {
        _movable.SetDirection(GetDirection());
    }

    protected abstract Vector3 GetDirection();
}
