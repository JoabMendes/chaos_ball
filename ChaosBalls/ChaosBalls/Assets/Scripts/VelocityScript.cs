using UnityEngine;
using System.Collections;

public class VelocityScript : MonoBehaviour {
	public float startSpeed = 50;
	// Use this for initialization
	void Start () {
		Rigidbody rigidBody = GetComponent<Rigidbody> ();
		rigidBody.velocity = new Vector3 (startSpeed, 0, startSpeed);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
