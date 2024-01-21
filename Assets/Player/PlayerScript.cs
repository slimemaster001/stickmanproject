using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerScript: MonoBehaviour
{
    private float horizontal;
    private float walkspeed = 8f;
    public float jumpstrengt = 16f;
    private bool isFacingRight = true;
    private float border_up = 69;
    private float border_down = -4;
    public LogicScript logic;
    [SerializeField] public bool playerisalive = true;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform groundCheck;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] public int level = 0;


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<LogicScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //for movement until //end of movement code
    if (playerisalive == true)
    {
        horizontal = Input.GetAxisRaw ("Horizontal");
    }    
    
    if (Input.GetButtonDown("Jump") && IsGrounded() && playerisalive == true )
    {
        Debug.Log("speace");
        rb.velocity = new Vector2(rb.velocity.x, jumpstrengt);
    }

    if (Input.GetButtonUp("Jump") && rb.velocity.y > 0f && playerisalive == true)
    {
        rb.velocity = new Vector2(rb.velocity.x, rb.velocity.y * 0.5f);
    }
    //border for movement until //border for movement end
        if (transform.position.y > border_up)
        {
            playerisalive = false;
        }

        if (transform.position.y < border_down)
        {
            playerisalive = false;
        }
        //border for movement end
    Flip();
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontal * walkspeed, rb.velocity.y);
    }
    private bool IsGrounded()
    {
        return Physics2D.OverlapCircle(groundCheck.position, 0.2f, groundLayer);
    }
    private void Flip()
    {
        if (isFacingRight && horizontal < 0f || !isFacingRight && horizontal > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 localScale = transform.localScale;
            localScale.x *= -1f;
            transform.localScale = localScale;
        }//end of movement code
    }  
}