using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChalkScript : MonoBehaviour
{
    public GameObject player;
    private TrailRenderer trail;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        trail = player.GetComponent<TrailRenderer>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag.Equals("Player"))
        {
            trail.enabled = true;
            sprite.enabled = false;
        }
    }
}
