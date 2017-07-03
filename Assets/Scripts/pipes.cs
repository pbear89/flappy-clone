using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes : MonoBehaviour {

	// Use this for initialization
	public Vector2 velocity = new Vector2(-4, 0);
	
	void Start () 
	{
		GetComponent<Rigidbody2D>().velocity = velocity;
	}
}
