using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    private Rigidbody2D rb;

    public Joystick JoyS;

    private float move;
    public float MoveSpeed;
    private Vector3 StartPosition;
    public Vector3 DashDistance;

    public GameObject ParticleEffect;

    private bool AttackMode;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GetComponent<LoopingBG>();

        StartPosition = rb.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        move = Input.GetAxis("Vertical");

        rb.velocity = new Vector2(rb.velocity.x, move * MoveSpeed);


        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
            
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "Enemy" )
        {
            Destroy(gameObject);
            Instantiate(ParticleEffect, transform.position, transform.rotation);
            GameObject.FindWithTag("BG").GetComponent<LoopingBG>().enabled = false; 

        }

    }

    public void Attack()

    {

        Vector3.MoveTowards(transform.position, DashDistance, 10);
        //rb.AddForce(Vector2.right, ForceMode2D.Impulse); // This is the Error Point //

        //rb.MovePosition(StartPosition);
    }

    
}
