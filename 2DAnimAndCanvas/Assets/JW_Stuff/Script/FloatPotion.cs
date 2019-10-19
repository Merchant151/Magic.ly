using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatPotion : MonoBehaviour
{
    Rigidbody2D rb;
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
            Vector2 newPosition = obj.gameObject.transform.position;
            newPosition = new Vector2(transform.position.x, transform.position.y + 1.3f);
            obj.gameObject.transform.position = newPosition;
            print("transport suc");

           rb = obj.GetComponent<Rigidbody2D>();
           rb.constraints = RigidbodyConstraints2D.FreezeAll;
        
        }
        print("freeze");
    }
}
