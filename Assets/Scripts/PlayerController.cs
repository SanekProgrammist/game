using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float speed;
    public float jumpForce;

    private bool isGround;
    private Rigidbody2D rigidbody2D;


    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        Vector3 position = transform.position;

        position.x += Input.GetAxis("Horizontal") * speed;

        transform.position = position;

        if(Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            isGround = false;
            Jump();
        }

        
    }
    private void Jump()
    {
        rigidbody2D.AddForce(transform.up * jumpForce, ForceMode2D.Impulse);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGround = true;
        }
    }
}
