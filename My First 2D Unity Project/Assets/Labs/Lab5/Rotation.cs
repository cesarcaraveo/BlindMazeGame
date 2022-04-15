using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float speed = 40;
    private float angle;

    // Start is called before the first frame update
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        angle = speed * Time.deltaTime;
        transform.RotateAround(transform.parent.position, Vector3.forward, angle);
    }
}
