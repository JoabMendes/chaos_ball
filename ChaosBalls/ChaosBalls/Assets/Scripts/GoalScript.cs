using UnityEngine;
using System.Collections;

public class GoalScript : MonoBehaviour {

	void OnTriggerEnter (Collider collider){
		GameObject collidedWith = collider.gameObject;

		if (collidedWith.tag == gameObject.tag) {
			GetComponent<Light> ().intensity = 0;
			Destroy (collidedWith);
		}
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
