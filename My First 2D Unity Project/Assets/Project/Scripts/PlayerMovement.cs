using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float horizontalSpeed;
    private float verticalSpeed;
    private const float MOVEMENT_SPEED = 9;
    private const float MAX_SPEED = 20;
    public AudioSource[] sounds;
    public Animator animator;
    private bool facingRight = true;
    private TrailRenderer trail;
    private Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponents<AudioSource>();
        //audio = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        //GetComponent<Renderer>().enabled = false;
        //InvokeRepeating("ToggleVisibility", 1.0f, 1.0f);
        trail = GetComponent<TrailRenderer>();
        trail.enabled = false;
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //Vector3 position = transform.position;
        //position.z = 0;
        //transform.position = position;

        //horizontalSpeed = Input.GetAxis("Horizontal");
        //verticalSpeed = Input.GetAxis("Vertical");
        //transform.Translate(Vector2.up * MOVEMENT_SPEED * verticalSpeed * Time.deltaTime);
        //transform.Translate(Vector2.right * MOVEMENT_SPEED * horizontalSpeed * Time.deltaTime);
    }

    void FixedUpdate()
    {
        horizontalSpeed = Input.GetAxis("Horizontal");
        verticalSpeed = Input.GetAxis("Vertical");

        if (horizontalSpeed * rigid.velocity.x < MAX_SPEED)
            rigid.AddForce(Vector2.right * horizontalSpeed * MOVEMENT_SPEED);

        if (verticalSpeed * rigid.velocity.y < MAX_SPEED)
            rigid.AddForce(Vector2.up * verticalSpeed * MOVEMENT_SPEED);

        if (Mathf.Abs(rigid.velocity.x) > MAX_SPEED)
            rigid.velocity = new Vector2(Mathf.Sign(rigid.velocity.x) * MAX_SPEED, rigid.velocity.y);

        if (Mathf.Abs(rigid.velocity.y) > MAX_SPEED)
            rigid.velocity = new Vector2(rigid.velocity.x * MAX_SPEED, Mathf.Sign(rigid.velocity.y));

        if (horizontalSpeed > 0 && !facingRight || horizontalSpeed < 0 && facingRight)
        {
            facingRight = !facingRight;

            Vector3 temp = transform.localScale;
            temp.x *= -1;
            transform.localScale = temp;
        }

        // compare to the abs value
        horizontalSpeed = Mathf.Abs(horizontalSpeed);

        // this test helps for numerical instability--sometimes a float is 0, but won't
        // be 0 (especially on an input device) and instead will be super close to zero
        if (horizontalSpeed > .0001f)
            animator.SetFloat("HorizontalSpeed", horizontalSpeed);
        else
            animator.SetFloat("HorizontalSpeed", 0.0f);

        // this test helps for numerical instability--sometimes a float is 0, but won't
        // be 0 (especially on an input device) and instead will be super close to zero
        if (verticalSpeed > .0001f || verticalSpeed < -0.001f)
            animator.SetFloat("VerticalSpeed", verticalSpeed);
        else
            animator.SetFloat("VerticalSpeed", 0.0f);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Wall")) { 
            sounds[0].Play(); // bounce sound
            //audio.Play();
        }
    }

    //private void ToggleVisibility()
    //{
    //    GetComponent<Renderer>().enabled = !GetComponent<Renderer>().enabled;
    //}
}
