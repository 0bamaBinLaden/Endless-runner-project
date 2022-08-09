using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour
{
    public float DifIncreaser;
    public float MoveLeftMag;

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        MoveLeftMag = MoveLeftMag + DifIncreaser; 
        transform.Translate(new Vector2(-MoveLeftMag * Time.deltaTime, 0));

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.tag == "DestroyPoint")
        {
            Destroy(gameObject);
        }
    }
}
