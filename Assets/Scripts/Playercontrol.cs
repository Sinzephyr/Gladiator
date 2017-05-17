using UnityEngine;
using System.Collections;

public class Playercontrol : MonoBehaviour {
	public Rigidbody PlayerRB;
	public GameObject Target;
	public GameObject Player;
	public GameObject finishPos;
	public GameObject[] enemies;
	public AudioSource keySound;
	Vector3 PlayerOrigin; // we will use this to store the original position of mover
	public float thrust;
	public Renderer rend;

		// Use this for initialization, similar to void setup() in Processing
		void Start () {
			PlayerOrigin = Player.transform.position; //store the original pos in moverOrigin
			PlayerRB = GetComponent<Rigidbody>();
		}

		// Update is called once per frame, similar to void draw() in Processing
		void Update () {
			Debug.Log("game object is at ... " + Player.transform.position);
			//Debug.Log("the key is at... " + keyPos);
			//check if the GetKeyDown function of Input returns true for "space" (the space bar)
		if (Input.GetKeyDown("left")){
				//if true ... move the position of mover by (0,1,0)
				Player.transform.position += new Vector3(-1,0,0);
			}
			if (Input.GetKeyDown("right")){
				//if true ... move the position of mover by (0,1,0)
				Player.transform.position += new Vector3(1,0,0);
			}
			if (Input.GetKeyDown("down")){
				//if true ... move the position of mover by (0,1,0)
				Player.transform.position += new Vector3(0,0,-1);
			}
			if (Input.GetKeyDown("up")){
				//if true ... move the position of mover by (0,1,0)
				Player.transform.position += new Vector3(0,0,1);
			}

		/*
			//check it the mover's position is less/greater than each border
			if ((Player.transform.position.z < -4)
				|| (Player.transform.position.z > 3)
				|| (Player.transform.position.x > 0)
				|| (Player.transform.position.x < -15))	{
				//if it is, reset to the original position (origin)
				Player.transform.position = PlayerOrigin;
			}
			
		*/
			//we use a loop to cycle through each one of our enemies, no matter how many positions are in the array
			for (int i = 0; i < enemies.Length; i++) {
				//so long as the enemy is not past the rightmost position on the board (3), move them by 0.2 per frame
				if (enemies[i].transform.position.z < 3){
					enemies[i].transform.position += new Vector3(0,0,.2f);
				} else {
					enemies[i].transform.position = new Vector3(enemies[i].transform.position.x,enemies[i].transform.position.y, -4);
				}


				//if the player is in the same position as the enemy, reset them and the key
				if (Player.transform.position == enemies[i].transform.position){
					Player.transform.position = PlayerOrigin;
					
				}

			}

		}
	/*void FixedUpdate(){
		if (Input.GetKeyDown ("up")) {
			PlayerRB.AddForce (transform.forward * thrust);
		}
		if (Input.GetKeyDown ("down")) {
			PlayerRB.AddForce (-transform.forward * thrust);
		}
		if (Input.GetKeyDown ("right")) {
			PlayerRB.AddForce (transform.right * thrust);
		}
		if (Input.GetKeyDown ("left")) {
			PlayerRB.AddForce (-transform.right * thrust);
		}
	}*/
}
