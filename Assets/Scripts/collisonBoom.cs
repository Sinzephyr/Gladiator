using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collisonBoom : MonoBehaviour {
	public Renderer rend;
	// Use this for initialization
	void Start () {
		rend = GetComponent<Renderer>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision colReport){
		if (colReport.gameObject.tag == "Enemy") {
			Debug.Log ("hit occurred");
			rend.material.color = Color.red;
		}
	}
}
