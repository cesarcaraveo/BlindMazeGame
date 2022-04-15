using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;

public class ClockScript : MonoBehaviour
{
    //public GameObject dirLight;
    //private Light light;
    private Text clock;
    private int minutes = 1;
    private float seconds = 0f;
    private bool timerOn;

    // Start is called before the first frame update
    void Start()
    {
        clock = GetComponent<Text>();
        //light = dirLight.GetComponent<Light>();
        timerOn = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Mathf.Round(seconds) == 0 && minutes == 0)
        {
            clock.text = "GAME OVER";
            timerOn = false;
            SceneManager.LoadScene("Game Over");
        }

        //else if (Mathf.Round(seconds) == 5 && minutes == 0)
        //{
        //    light.intensity = .25f;
        //    seconds -= Time.deltaTime;
        //    string minute = minutes.ToString().PadLeft(2, '0');
        //    string second = Mathf.Round(seconds).ToString().PadLeft(2, '0');

        //    clock.text = minute + ":" + second;
        //}

        //else if (Mathf.Round(seconds) == 4 && minutes == 0)
        //{
        //    light.intensity = 0;
        //    seconds -= Time.deltaTime;
        //    string minute = minutes.ToString().PadLeft(2, '0');
        //    string second = Mathf.Round(seconds).ToString().PadLeft(2, '0');

        //    clock.text = minute + ":" + second;
        //}

        else if (timerOn)
        {
            if (seconds < 0)
            {
                minutes = minutes - 1;
                seconds = 59;
            }

            seconds -= Time.deltaTime;
            string minute = minutes.ToString().PadLeft(2, '0');
            string second = Mathf.Round(seconds).ToString().PadLeft(2, '0');

            clock.text = minute + ":" + second;
        }
    }
}
