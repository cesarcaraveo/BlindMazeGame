using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseWorldPosition : MonoBehaviour
{
    public Vector3 worldPoint;
    public Vector3 mousePos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Camera camera = GetComponent<Camera>();
        worldPoint = camera.ScreenToWorldPoint(new Vector3 (Input.mousePosition.x, Input.mousePosition.y,
            Input.mousePosition.z));

        mousePos = new Vector3(worldPoint.x, worldPoint.y, 0);
    }
}
