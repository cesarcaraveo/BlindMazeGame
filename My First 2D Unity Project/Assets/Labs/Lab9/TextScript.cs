using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeText(Object obj)
	{
        Text b = ((GameObject)obj).GetComponent<Text>();

        b.text = "3";
	}
}
