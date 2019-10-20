using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeletePot : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.GetComponent<Collider2D>().tag == "CanMove")
        {
            Destroy(obj.gameObject);
        }
        if (obj.gameObject.GetComponent<Collider2D>().tag == "LevelTwo")
        {
            SceneManager.LoadScene("LevelTwo");
        }
        if (obj.gameObject.GetComponent<Collider2D>().tag == "LevelThree")
        {
            SceneManager.LoadScene("LevelThree");
        }
        if (obj.gameObject.GetComponent<Collider2D>().tag == "End")
        {
            SceneManager.LoadScene("End");
        }
    }
}