using UnityEngine;

public class MovementMorgan : MonoBehaviour
{
    public PlayerInventoryValue item;
    Vector2 _movement;
    [SerializeField]
    Rigidbody2D _rigidBody;

    float _speed = 5f;
    [SerializeField]
    Animator _animator;
    Vector2 _lastDirection;

    bool canMove = true;
    bool isMonologue = false;

    void Update()
    {
        StopMoveDialogue();
        HandleInput();
        HandleAnimation();
    }

    void FixedUpdate()
    {
        if (canMove)
        {
            _rigidBody.MovePosition(_rigidBody.position + _movement * _speed * Time.fixedDeltaTime);
        }
    }

    void HandleInput()
    {
        if (!canMove)
        {
            _movement = Vector2.zero;
            return;
        }

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

    void StopMoveDialogue()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            canMove = isMonologue;
        }
        else
        {
            canMove = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("NPCDialogue"))
        {
            isMonologue = false;
            canMove = false;
        }
        else if (collider.CompareTag("Monologue"))
        {
            isMonologue = true;
            canMove = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.CompareTag("NPCDialogue") || collider.CompareTag("Monologue"))
        {
            isMonologue = false;
            canMove = true;
        }
    }
}
