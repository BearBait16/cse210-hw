using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Jumpy : Enemy
{
    private float jump = 5f;

    protected override void OnCollisionEnter2D(Collision2D other)
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
        else if (other.gameObject.tag == "Floor")
        {
            Jump();
        }
    }

    protected virtual void Jump()
    {
        rb.AddForce(transform.up * jump, ForceMode2D.Impulse);
    }
    private void FixedUpdate()
    {
        rb.AddForce(Physics.gravity * rb.mass);
    }
}
