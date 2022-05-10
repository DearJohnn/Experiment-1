using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour
{
    private Rigidbody2D rb2d;
    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }
    void ResetBall()
    {
        rb2d.velocity = Vector2.zero;
        transform.position = Vector2.zero;
    }
    void RestartGame()
    {
        ResetBall();
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.collider.CompareTag("Player"))
        {
            Vector2 vel;
            vel.x = rb2d.velocity.x;
            if (vel.x > 0)
            {
                rb2d.AddForce(new Vector2(10, 1));
                vel.y = (rb2d.velocity.y + 3) + (coll.collider.attachedRigidbody.velocity.y / 3);
                rb2d.velocity = vel;
            }
            else if(vel.x <= 0)
            {
                rb2d.AddForce(new Vector2(-10, 1));
                vel.y = (rb2d.velocity.y + 3) + (coll.collider.attachedRigidbody.velocity.y / 3);
                rb2d.velocity = vel;
            }
            
            
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
