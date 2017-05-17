using UnityEngine;
using System.Collections;

public class Crowdcheer : MonoBehaviour {
	public float speed;
	public Vector3 crowdOrigin;
	float range;
	// Use this for initialization
	void Start () {
		crowdOrigin = transform.position;
		range = Random.Range (2, 5);
	}
	
	// Update is called once per frame
	void Update () {
		speed += 1.0f;
		transform.position = crowdOrigin + new Vector3 (0, Mathf.Sin (Time.time * range), 0);
	}
}
