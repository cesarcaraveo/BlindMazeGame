using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteScript : MonoBehaviour
{
    public float initialPosition;
    public float endingPosition;
    public Vector3 position;
    private bool movingRight = true;
    private bool growing = true; 
    private float speed;
    private float rotate;
    private float scale;
    private float temp;

    private Vector3 initScale = new Vector3(0,0,0);
    private Vector3 endScale = new Vector3(2,2,2); 

    // must create tag first
    GameObject obj;
    GameManagerScript sm;

    // Start is called before the first frame update
    void Start()
    {
        obj = GameObject.FindGameObjectWithTag("GameManager");
        sm = obj.GetComponent<GameManagerScript>();

        // create a new vector to translate the sprite
        position = new Vector3(initialPosition, 0, 0);
        transform.position = position;

        // if moving left first
        // change the variables to make it work 
        if (initialPosition > endingPosition) {
            movingRight = !movingRight;
            temp = initialPosition;
            initialPosition = endingPosition;
            endingPosition = temp;
        }

        speed = sm.movementSpeed;
        rotate = sm.rotationSpeed;
        scale = sm.scalingSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        // if moving right but haven't reached end, keep moving
        if (movingRight && transform.position.x < endingPosition)
        {
            transform.Translate(speed * Time.deltaTime, 0, 0, Space.World);
            transform.Rotate(0, 0, rotate * Time.deltaTime, Space.World);
            //transform.localScale = Vector3.Lerp(transform.localScale, endScale, scale * Time.deltaTime);
        }

        // if moving right but got to the end, change direction
        else if (movingRight && transform.position.x >= endingPosition)
        {
            movingRight = !movingRight;
            transform.Translate(-1 * speed * Time.deltaTime, 0, 0, Space.World);
            transform.Rotate(0, 0, rotate * Time.deltaTime, Space.World);
            //transform.localScale = Vector3.Lerp(transform.localScale, endScale, scale * Time.deltaTime);
        }

        // if moving left but haven't reached end, keep moving
        else if (!movingRight && transform.position.x > initialPosition)
        {
            transform.Translate(-1 * speed * Time.deltaTime, 0, 0, Space.World);
            transform.Rotate(0, 0, rotate * Time.deltaTime, Space.World);
            //transform.localScale = Vector3.Lerp(transform.localScale, endScale, scale * Time.deltaTime);
        }

        // if moving left but reached end, change
        else if (!movingRight && transform.position.x <= initialPosition)
        {
            movingRight = !movingRight;
            transform.Translate(-1 * speed * Time.deltaTime, 0, 0, Space.World);
            transform.Rotate(0, 0, rotate * Time.deltaTime, Space.World);
            //transform.localScale = Vector3.Lerp(transform.localScale, endScale, scale * Time.deltaTime);
        }

        // scaling code
        if (growing && transform.localScale.x < endScale.x - .1f)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, endScale, scale * Time.deltaTime);
        }

        else if (growing && transform.localScale.x >= endScale.x - .1f)
        {
            growing = !growing;
            transform.localScale = Vector3.Lerp(transform.localScale, initScale, scale * Time.deltaTime);
        }

        else if (!growing && transform.localScale.x > initScale.x + .1f)
        {
            transform.localScale = Vector3.Lerp(transform.localScale, initScale, scale * Time.deltaTime);
        }

        else if (!growing && transform.localScale.x <= initScale.x + .1f)
        {
            growing = !growing;
            transform.localScale = Vector3.Lerp(transform.localScale, endScale, scale * Time.deltaTime);
        }
    }
}
