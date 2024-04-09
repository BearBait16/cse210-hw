using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float speed = 8f;

    [SerializeField]
    Rigidbody2D this_Rigidbody;

    [SerializeField]
    private float jump = 15f;

    [SerializeField]
    private float gravityScale = 5f;
    // Start is called before the first frame update

    [SerializeField]
    private bool haskey = false;
    private void Start()
    {
        this_Rigidbody = GetComponent<Rigidbody2D>();
    }

    // Runs the Listening programs
    private void Update()
    {
        Movement();
        Jump();
    }
    // Moves you when you use the left/right arrows or a/d
    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * speed * horizontalInput * Time.deltaTime);
    }
    //When Space is pressed, Place force on this Game Object
    // -Note: This gets overidden by the UI always. Changing numbers doesn't do anything
    private void Jump()
    {
        if (Input.GetKeyDown("space"))
        {
            this_Rigidbody.AddForce(transform.up * jump, ForceMode2D.Impulse);
        }
    }

    private void FixedUpdate()
    {
        this_Rigidbody.AddForce(Physics.gravity * (gravityScale - 1) * this_Rigidbody.mass);
    }

    public void SetHasKey(bool key)
    {
        haskey = key;
        //Allow the opening of the door if key is retrieved
    }

    public bool GetHasKey()
    {
        return haskey;
    }
}
