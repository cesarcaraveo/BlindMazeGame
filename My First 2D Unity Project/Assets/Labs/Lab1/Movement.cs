using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 0.2f;
    private int counter = 0;

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
        gameObject.transform.Rotate(0.0f, 0.0f, -10.0f * Time.deltaTime, Space.World);
        print(counter++);
    }
}
