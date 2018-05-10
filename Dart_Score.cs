using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dart_Score : MonoBehaviour {
	
	private GameObject redDart;
	private GameObject Scoreboard;
	private GameObject TwentyRedAX;
	
	void Awake()
	{
		Scoreboard = GameObject.Find("Scoreboard");
		TwentyRedAX = GameObject.Find("20RedAX");
		redDart =  GameObject.FindWithTag("Red");
	}

	
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Red"))
		{
			Destroy (other.gameObject);
			//Rigidbody temp = other.GetComponent<Rigidbody>;
			//temp.velocity = Vector3.zero;

			print ("Red hit 20");
			TwentyRedAX.GetComponent<Renderer>().enabled = true;
		}
	}
}
