using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    // Start is called before the first frame update
	public GameObject obstacle;
	public float spawnRate;
	public float maxXpos;

    void Start()
    {
    		StartSpawning();
        
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetKeyDown(KeyCode.Space))
        // {
        // 	Spawn();
        // }
    }

    void Spawn()
    {
    	float randomX = Random.Range(-maxXpos,maxXpos);
    	Vector2 spawnPos = new Vector2(randomX, transform.position.y);

    	Instantiate(obstacle, spawnPos, Quaternion.identity);

    }

    void StartSpawning() //for keep on coming barrel
    {
    		InvokeRepeating("Spawn",2f,spawnRate);  // 1f = after 1 sec

    }

    public void StopSpawning()

	{
		CancelInvoke("Spawn");

	}

}
