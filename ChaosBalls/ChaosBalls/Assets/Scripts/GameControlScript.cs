using UnityEngine;
using System.Collections;

public class GameControlScript : MonoBehaviour {


	public GameObject blueBall, greenBall, redBall, orageBall;

	private bool isGameOver = false;
	
	// Update is called once per frame
	void Update () {
		//If all four ball are not (!) existent then game is over
		isGameOver = !blueBall && !greenBall && !redBall && !orageBall;
		//The balls are destroyed when collide with the lights goals
	}

	void OnGUI(){
		if (isGameOver) {
			Rect rect = new Rect (Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 110);
			GUI.Box (rect, "Game Over");

			Rect rect2 = new Rect (Screen.width / 2 - 30, Screen.height / 2 - 25, 200, 110);
			GUI.Label (rect2, "Good Job!\n\nCredits:\nJoab Mendes");
		}
	
	}
}
