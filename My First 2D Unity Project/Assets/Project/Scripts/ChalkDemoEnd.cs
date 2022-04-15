using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChalkDemoEnd : MonoBehaviour
{
    private AudioSource[] sounds;

    // Start is called before the first frame update
    void Start()
    {
        sounds = GetComponents<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {

        if (other.tag.Equals("Player"))
        {
            sounds[0].Play();

            Invoke("nextScene", 0.5f);


        }
    }

    void nextScene()
    {
        SceneManager.LoadScene("LanternInstructions");
    }
}
