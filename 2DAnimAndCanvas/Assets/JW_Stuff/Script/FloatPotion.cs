using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FloatPotion : MonoBehaviour
{
    Rigidbody2D rb;

    void OnTriggerEnter2D(Collider2D obj)
    {
        if (obj.gameObject.GetComponent<Collider2D>().tag == "CanMove")
        {
            if (obj.gameObject.GetComponent<Collider2D>().tag == "CanMove")
            {
                Vector2 newPosition = obj.gameObject.transform.position;
                newPosition += new Vector2(0, 1.3f);
                obj.gameObject.transform.position = newPosition;
                

                rb = obj.GetComponent<Rigidbody2D>();
                rb.constraints = RigidbodyConstraints2D.FreezeAll;

            }
            print("freeze");
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
