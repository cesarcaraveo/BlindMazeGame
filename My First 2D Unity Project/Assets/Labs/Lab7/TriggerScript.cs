using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("In Trigger");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("In Trigger");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("In Trigger");
    }
}
