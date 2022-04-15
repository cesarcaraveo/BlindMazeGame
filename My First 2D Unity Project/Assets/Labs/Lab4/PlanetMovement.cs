using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetMovement : MonoBehaviour
{
    public float speed = 40;
    public float angle;

    void Update()
    {
        angle = speed * Time.deltaTime;

        // rotation around earth 
        transform.RotateAround(transform.parent.position, Vector3.forward, angle);

        // rotation around big moon
        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).RotateAround(transform.position, Vector3.forward, angle);
        }
    }
}
