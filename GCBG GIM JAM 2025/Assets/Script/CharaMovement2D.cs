using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{

    private PlayerInventoryValue item;
    // Public fields
    public float speed = 1;

    // Private fields
    Rigidbody2D rb;
    float horizontalValue;
    bool facingRight = true;
    bool canMove = true;
    bool isMonologue = false;
    
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        horizontalValue = Input.GetAxisRaw("Horizontal");
        if (canMove)
        {
            horizontalValue = Input.GetAxisRaw("Horizontal");
        }
        else
        {
            horizontalValue = 0;
        }
        //Debug.Log(horizontalValue);
    }
    void FixedUpdate()
    {

        Move(horizontalValue);
        StopMoveDialogue();
    }

    void Move(float dir)
    {
        float xVal = dir * speed * 100 * Time.deltaTime;
        Vector2 targetVelocity = new Vector2(xVal, rb.linearVelocity.y);
        rb.linearVelocity = targetVelocity;

        if (facingRight && dir < 0)
        {
            transform.localScale = new Vector3(-0.35f, 0.35f, 0.35f);
            facingRight = false;
        }
        else if (!facingRight && dir > 0)
        {
            transform.localScale = new Vector3(0.35f, 0.35f, 0.35f);
            facingRight = true;
        }
    }

    void StopMoveDialogue()
    {
        if (DialogueManager.GetInstance().dialogueIsPlaying)
        {
            //Debug.Log("Dialog lagi jalan dialognpc bukan?" + isMonologue);
            canMove = isMonologue; // Jika isMonologue = true, player tetap bisa bergerak
        }
        else
        {
            canMove = true; // Jika tidak ada dialog, player bisa bergerak bebas
        }
        //Debug.Log(""+ canMove);
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

