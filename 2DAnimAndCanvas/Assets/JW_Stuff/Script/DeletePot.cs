﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        print("delete");
    }
}