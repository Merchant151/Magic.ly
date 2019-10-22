using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotCounter : MonoBehaviour {
    public int startCount;
    int count;
    public KeyCode key;
    public GameObject myPrefab;
    //public GameObject collectable;
    GameObject[] collectables;

   //My Components
   Text myText;
    Button myButton;

	// Use this for initialization
	void Start () {
        myText = GetComponentInChildren<Text>();
        myButton = GetComponent<Button>();
        setCount(0);
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
            bool direction = GameObject.FindGameObjectWithTag("Player").GetComponent<SpriteRenderer>().flipX;
            float m = -1f;
            if (direction == false)
                m = 1f;
            Instantiate(myPrefab, GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position+(new Vector3(1,0,0)*m), Quaternion.identity);
            consume();
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            float Px = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.x;
            float Py = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position.y;
            collectables = GameObject.FindGameObjectsWithTag(myPrefab.tag); 
            Debug.Log("E was pressed");
            foreach(GameObject collectable in collectables)
            {
                float Cx = collectable.GetComponent<Transform>().position.x;
                float Cy = collectable.GetComponent<Transform>().position.y;
                if(Mathf.Abs(Px-Cx) <= 0.35 && Py-Cy <= 1.5)
                {
                    Debug.Log("count"+count);
                    setCount(count+1);
                    Debug.Log("cur count" + count);
                    myButton.interactable = true;
                    Destroy(collectable);
                }
            }
        }
	}
}
