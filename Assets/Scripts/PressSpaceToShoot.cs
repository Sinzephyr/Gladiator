using UnityEngine;
using System.Collections;

public class PressSpaceToShoot : MonoBehaviour {

	public Rigidbody projectile;
	public float speed = 30f;
	public float timer;


	void Start () 
	{
		Cursor.visible = false;


	}

	// Update is called once per frame
	void Update () { if (Input.GetKeyDown("space")) {
			Rigidbody instantiatedProjectile = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody;
			instantiatedProjectile.velocity = transform.TransformDirection(new Vector3(0, 0, speed)); }
		/*timer += 1.0f * Time.deltaTime;

		if(timer >= 4)
		{ GameObject.Destroy (gameObject);}*/
	}
}