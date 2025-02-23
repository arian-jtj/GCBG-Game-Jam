using UnityEngine;

public class MovementMorgan : MonoBehaviour
{
    Vector2 _movement;
    [SerializeField]
    Rigidbody2D _rigidBody;

    float _speed = 5f;

    [SerializeField]
    Animator _animator;
    Vector2 _lastDirection;

    void Update()
    {
        HandleInput();
        HandleAnimation();
    }
    void FixedUpdate()
    {
        _rigidBody.position = _rigidBody.position + _movement * _speed * Time.fixedDeltaTime;
    } 

    void HandleInput()
    {
        float horizontalMovement = Input.GetAxisRaw("Horizontal");
        if (horizontalMovement == 0 && _movement.x != 0)
        {
            _lastDirection = _movement;
        }
        _movement = new Vector2(horizontalMovement, 0);


    }
    void HandleAnimation()
    {
        _animator.SetFloat("Square Magnitude", _movement.sqrMagnitude);
        _animator.SetFloat("Horizontal Movement", _movement.x);
        if (_lastDirection.x != 0)
        {
            _animator.SetFloat("Last Direction", _lastDirection.x);
        }

    }
}
