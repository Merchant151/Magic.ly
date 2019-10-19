using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : MonoBehaviour
{
    //Vector3 dest;
    //float curAngD;
    //float curAngR;
    //Vector3 step;
    Rigidbody2D body;
    
    

    // Start is called before the first frame update
    void Start()
    {
        body = GetComponent<Rigidbody2D>();
        body.AddForce(GameObject.FindGameObjectWithTag("Player").GetComponent<JW_PLayerController>().throwForce, ForceMode2D.Impulse);
       /* Vector3 local = transform.position;
        curAngD = 90.0f;
        curAngR = curAngD / 180 * Mathf.PI;
        dest = new Vector3(curAngR - (Mathf.Cos(1 / 180 * Mathf.PI)), Mathf.Sin(1 / 180 * Mathf.PI),0);
        step = dest * Time.deltaTime;
        */
    }

    // Update is called once per frame
    void Update()
    {   
        /*
        transform.position += step;
        curAngD = curAngD - 1.0f;
        curAngR = curAngD / 180 * Mathf.PI;
        dest = new Vector3(curAngR - (Mathf.Cos(1 / 180 * Mathf.PI)), Mathf.Sin(1 / 180 * Mathf.PI),0);
        */
    }


}
