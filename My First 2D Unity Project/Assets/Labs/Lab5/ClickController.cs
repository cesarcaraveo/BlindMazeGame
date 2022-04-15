using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickController : MonoBehaviour
{
    MouseWorldPosition mousePos;
    Bounds bound;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
       mousePos = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<MouseWorldPosition>();
        bound = GetComponent<SpriteRenderer>().bounds;

        Vector3 worldPoint = new Vector3(mousePos.mousePos.x, mousePos.mousePos.y, transform.position.z);

        if (Input.GetMouseButtonDown(0) && bound.Contains(worldPoint))
        {
            Debug.Log("Object was clicked");
        }
    }
}
