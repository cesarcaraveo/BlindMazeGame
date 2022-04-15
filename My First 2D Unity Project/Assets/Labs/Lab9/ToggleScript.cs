using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{
    public Text txt;
    private bool isOn;

    // Start is called before the first frame update
    void Start()
    {
        isOn = false;
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void changeToggle()
	{
        isOn = !isOn;

        if (isOn)
		{
            txt.text = "Red";
		}
	}

}
