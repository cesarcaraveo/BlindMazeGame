using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PatrolScript : MonoBehaviour
{
    public float speed; // control speed
    public List<Vector3> points; // list of points to patrol

    private Coroutine patrol; // patrol coroutine reference
    private Coroutine colorChange; // color coroutine reference

    // Start is called before the first frame update
    void Start()
    {
        patrol = StartCoroutine(Patrol()); // start patrol coroutine
        colorChange = StartCoroutine(ChangeColor()); // start color change coroutine
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StopPatrol();
        }
    }

    // coroutine
    protected IEnumerator Patrol()
    {
        while (true)
        {
            foreach (Vector3 point in points)
            {
                // if ball has not reached point
                while (transform.position != point)
                {
                    // move towards it
                    transform.position = Vector3.MoveTowards(transform.position, point, speed * Time.deltaTime);
                    yield return null;
                }
            }
            yield return null;
        }
    }

    public void StopPatrol()
    {
        StopCoroutine(patrol);
    }

    // coroutine
    protected IEnumerator ChangeColor()
    {
        while (true)
        {

            GetComponent<SpriteRenderer>().color = Color.Lerp(Color.white, Color.black, Mathf.PingPong(Time.time, 1f));

            yield return null;
        }
    }
}
