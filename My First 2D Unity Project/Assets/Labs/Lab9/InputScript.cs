using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputScript : MonoBehaviour
{
    public Text txt;
    // Start is called before the first frame update
    void Start()
    {
        //txt = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void copyText(Object obj)
	{
        Text theText = ((GameObject)obj).GetComponent<Text>();
   
		txt.text = theText.text;
	}
}
