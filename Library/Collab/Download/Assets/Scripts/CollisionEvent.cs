using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    public GameManager gameManager;

	void OnCollisionEnter(Collision col)
	{
		if(col.gameObject.tag == "Player")
			Destroy(col.gameObject);
		if (col.gameObject.tag == "Obstacle")
        	{
            		GetComponent<UserControl>().enabled = false;
            		gameManager.EndGame();
		}
	}    
}
