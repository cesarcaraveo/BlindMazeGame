using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
