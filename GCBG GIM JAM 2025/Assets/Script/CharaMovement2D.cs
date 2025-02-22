using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Public fields
    public float speed = 1;

    // Private fields
    Rigidbody2D rb;
    float horizontalValue;
    bool facingRight = true;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalValue = Input.GetAxisRaw("Horizontal");
        //Debug.Log(horizontalValue);
    }
    void FixedUpdate()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            return;
        }
        Move(horizontalValue);
    }

    void Move(float dir)
    {
        float xVal = dir * speed * 100 * Time.deltaTime;
        Vector2 targetVelocity = new Vector2(xVal, rb.linearVelocity.y);
        rb.linearVelocity = targetVelocity;

        if (facingRight && dir < 0)
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 0.5f);
            facingRight = false;
        }
        else if (!facingRight && dir > 0)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            facingRight = true;
        }
    }
}

