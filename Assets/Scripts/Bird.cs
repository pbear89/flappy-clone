using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour {
	//Velodidad de Movimiento
	public float velocidad = 2;

	 // Aleteo
    public float aleteo = 300;

	// Use this for initialization
	void Start () {
		//Vuelo hacia la derecha
		GetComponent<Rigidbody2D>().velocity = Vector2.right * velocidad;	
	}
	
	// Update is called once per frame
	void Update () {
		 if (Input.GetKeyDown(KeyCode.Space))
            GetComponent<Rigidbody2D>().AddForce(Vector2.up * aleteo);
    
	}
	
	 // Reinicio
	void OnCollisionEnter2D(Collision2D coll) {
   
    //Application.LoadLevel(Application.loadedLevel);
	UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);   
}
}
