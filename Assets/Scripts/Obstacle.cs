using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotationSpeed;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
    	transform.Rotate(0,0,rotationSpeed);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
    	if(collision.gameObject.tag=="Player")
    	{
    		Destroy(collision.gameObject);  //destroy player if objects collided
    		GameManager.instance.GameOver();  //stop spawning    	}
    	}
    	if(collision.gameObject.tag=="Ground")
    	{	
    		GameManager.instance.IncrementScore(); //everytime barrel hit the ground call score()
    		Destroy(gameObject);
    	}

    
 }
}
