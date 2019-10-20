using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JW_PLayerController : MonoBehaviour {
    float speed = 5;
    public Vector2 throwForce = new Vector2(3,4);


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
            myAnim.SetBool("isWalking", true);
        }
        else if (h < 0)
        {
            mySprite.flipX = true;
            myAnim.SetBool("isWalking", true);
        }
        else
        {
            myAnim.SetBool("isWalking", false);
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            myBod.velocity = Vector2.up * 3.5f;
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Scene scene = SceneManager.GetActiveScene();
            SceneManager.LoadScene(scene.name);
        }

    }
    public void changeSpeed (float f)
    {
        speed += f;
    }

    
}
