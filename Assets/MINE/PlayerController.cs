using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerController : MonoBehaviour
{
public Rigidbody2D rb;
public int speed;
public LogicScript logic;
public bool birdIsAlive = true;
public Animator animator;

    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicScript>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
        Debug.Log("Space key pressed and bird is alive");
        rb.velocity = Vector2.up * speed;
        //animator.SetTrigger("Jump");
        animator.CrossFadeInFixedTime("Jump", 0.1f);
        Debug.Log("Jump trigger set");
        }

    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        logic.gameOver();
        birdIsAlive = false;
    }
}
