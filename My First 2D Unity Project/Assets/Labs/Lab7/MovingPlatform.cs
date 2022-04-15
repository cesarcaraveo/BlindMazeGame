using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float speed;
    private float origin;

    // Start is called before the first frame update
    void Start()
    {
        origin = transform.position.x;
        speed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        if (transform.position.x >= origin + 3 || transform.position.x <= origin - 3)
        {
            speed = speed * -1;
        }

            transform.position += new Vector3(speed * Time.deltaTime, 0, transform.position.z);
    }

    // called when this object or another object collides with us
    void OnCollisionEnter2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name + " entered a collision with me!");
    }

    // called if two objects are overlapping
    void OnCollisionStay2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name + " is in a collision with me!");
    }

    // called if the other object is leaving the collision
    void OnCollisionExit2D(Collision2D col)
    {
        Debug.Log(col.gameObject.name + " left a collision with me!");
    }
}
