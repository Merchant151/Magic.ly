using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatePotion : MonoBehaviour
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
            Vector3 newRotation = obj.gameObject.transform.position;
            obj.transform.eulerAngles = Vector3.forward * 90;
            obj.gameObject.transform.position = newRotation;
            print("transport suc");

            //rb = obj.GetComponent<Rigidbody2D>();
            //rb.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        //print("freeze");
    }
}
