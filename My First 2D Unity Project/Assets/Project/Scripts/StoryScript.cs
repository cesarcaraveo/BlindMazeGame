using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StoryScript : MonoBehaviour
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


    void startDemo()
    {
        sounds[0].Play();
        Invoke("nextScene", 0.5f);
    }

    void nextScene()
    {
        SceneManager.LoadScene("Demo");
    }
}
