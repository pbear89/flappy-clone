using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipes_repeat1 : MonoBehaviour {
	public GameObject pipes;

	void Start () {
		InvokeRepeating("CreateObstacle", 1f, 1.5f);
	}
	
	void CreateObstacle()
	{
		Instantiate(pipes);
	}
}
