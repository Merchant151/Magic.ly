using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JW_PLayerController : MonoBehaviour {
    float speed = 5;
    //My Components
    Rigidbody2D myBod;
    SpriteRenderer mySprite;
    Animator myAnim;
	// Use this for initialization
	void Start () {
        myBod = GetComponent<Rigidbody2D>();
        mySprite = GetComponent<SpriteRenderer>();
        myAnim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
        float h = Input.GetAxis("Horizontal");
        myBod.velocity = new Vector2(h * speed, myBod.velocity.y);
        myAnim.speed = speed * 0.3f;

        if (h > 0)
        {
            mySprite.flipX = false;
            myAnim.SetBool("IsRunning", true);
        }
        else if (h < 0)
        {
            mySprite.flipX = true;
            myAnim.SetBool("IsRunning", true);
        }
        else
        {
            myAnim.SetBool("IsRunning", false);
        }
	}
    public void changeSpeed (float f)
    {
        speed += f;
    }
}
