using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotCounter : MonoBehaviour {
    public int startCount;
    int count;
    public KeyCode key;

    //My Components
    Text myText;
    Button myButton;

	// Use this for initialization
	void Start () {
        myText = GetComponentInChildren<Text>();
        myButton = GetComponent<Button>();
        setCount(startCount);
        //key = KeyCode.Alpha0;

	}
	
    void setCount (int c)
    {
        count = c;
        myText.text = "" + count;
        if(count <= 0)
        {
            myButton.interactable = false;
        }
    }

    public void consume()
    {
        setCount(count - 1);
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(key)&&count>=1)
        {
            consume();
        }
	}
}
