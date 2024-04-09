using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : MonoBehaviour
{
    private Scene scene;
    protected bool directionRight = true;
    protected BoxCollider2D bc;
    protected Rigidbody2D rb;
    protected Vector3 direction;
    // rb.gravityScale = 5;
    protected int speed = 20;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.AddComponent<Rigidbody2D>();
        bc = gameObject.AddComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Enemy_Movement();
    }

    protected virtual void Enemy_Movement()
    {
        if (directionRight == true)
        {
            direction = Vector3.right;
        }
        else if (directionRight == false)
        {
            direction = Vector3.left;
        }
        transform.Translate(direction * speed * Time.deltaTime);
    }

    protected virtual void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            // scene.Reset();
            Debug.Log("You touched!");
        }
        else if (other.gameObject.tag == "Background")
        {
            directionRight = !directionRight;
        }
    }
}