using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifer : MonoBehaviour
{
	private GameObject player;
	void Start() {
		player = GameObject.Find("Player");
		
	}
	void OnCollisionEnter2D(Collision2D collision)
	{
		print("hello");
		if (collision.gameObject.tag == "Enemy")
		{	
			print("sussy baka");					
			collision.gameObject.GetComponent<Walker>().health = collision.gameObject.GetComponent<Walker>().health - 25;
			if (collision.gameObject.GetComponent<Walker>().health <= 0) {
				Destroy(collision.gameObject);
				player.GetComponent<Player>().coins = player.GetComponent<Player>().coins + 5;
			
			}
		}  
			
	}
}
