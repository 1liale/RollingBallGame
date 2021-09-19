using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionEvent : MonoBehaviour
{
    public GameManager gameManager;

    private new Rigidbody rigidbody;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }
    

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.tag == "Obstacle")
        {
            GetComponent<UserControl>().enabled = false;
            gameManager.EndGame();
		}
        else if (col.collider.tag == "AccelPad")
        {
            rigidbody.AddForce(50, -100, 100);
        }
	}    
}
