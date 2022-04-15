using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LanternScript : MonoBehaviour
{
    public GameObject player;
    private Light light;
    private SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        light = player.GetComponentInChildren<Light>();
        sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Player"))
        {
            light.enabled = true;
            sprite.enabled = false;
        }
    }
}
