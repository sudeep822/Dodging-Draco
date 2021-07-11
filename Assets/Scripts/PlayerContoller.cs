using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerContoller : MonoBehaviour
{
    Rigidbody2D rb;
    public float moveSpeed;
    SpriteRenderer sp;


    private void Awake()
    {
    	rb = GetComponent<Rigidbody2D>();
    	sp = GetComponent<SpriteRenderer>();
    }

    void Start()
    {
        
    }

 
    void Update()
    {
        
    }

    private void FixedUpdate(){

     if (Input.GetMouseButton(0))
     {
     	if(Input.mousePosition.x < Screen.width / 2)
     	{
     		//move left
     		rb.velocity = Vector2.left * moveSpeed;
     		sp.flipX =true;




     	}
     	else

     	{  //move right
     		rb.velocity = Vector2.right * moveSpeed;
     		sp.flipX = false;
 
     	}
     }

    }
}
