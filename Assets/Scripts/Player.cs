using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
    
    // public variables
    public float jumpForce = 10.0f;
    public int movementSpeed = 10;

    // public static variables
	public static bool alive = true;

	// private variables
	private bool jump = false;
    private bool grounded;
	private Animator animator;

	// death forces variabless
	public float deathForce = 10f;
	public float deathJump = 5f;

    void Awake ()
    {
		// get the animator component
        animator = GetComponent<Animator>();
    }

	// Trigger Handler
	void OnTriggerEnter2D (Collider2D col)
	{
		// deadly trigger
		if (col.gameObject.tag == "deadly") alive = false;

		// score trigger
		if (col.gameObject.tag == "SI") Score.score++;
	}

	// check grounded or not
    void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.tag == "grounded")
			animator.SetInteger ("animState", 0);
            grounded = true;
    }

	// run every frame
	// check jump, alive
	void Update () {
	    if (Input.GetButtonDown("Fire1"))
        {
            if (grounded == true)
            {
                jump = true;
                animator.SetInteger("animState",1);
                grounded = false;
            }
        }
		if (alive == false) onDeath();
	}

	void FixedUpdate()
    {
        if (alive) 
            GetComponent<Rigidbody2D>().velocity = new Vector2 (movementSpeed, GetComponent<Rigidbody2D>().velocity.y);
        
        if (jump) {
            GetComponent<Rigidbody2D>().AddForce (new Vector2 (0, jumpForce), ForceMode2D.Impulse);
            animator.SetInteger("animState", 1);	
            jump = false;
        }
    }
       
	// run when alive == false; || player is dead
	void onDeath () 
	{
		GetComponent<Rigidbody2D>().velocity = new Vector2 (0, GetComponent<Rigidbody2D>().velocity.y);
		GetComponent<Rigidbody2D>().AddForce (new Vector2 (deathForce, deathJump));
		animator.SetInteger ("animState", 2);
		Destroy(gameObject.GetComponent("BoxCollider2D"));
	}
	
}
