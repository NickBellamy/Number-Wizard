using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	int max;
	int min;
	int guess;
	bool won;

	// Use this for initialization
	void Start () {
		StartGame();
	}
	
	void StartGame() {
		max = 1000;
		min = 1;
		guess = Random.Range(min, max);
		
		print ("========================");
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me!");
		
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is "+ min);
		
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, Down = lower, Return = equals");
		
	}
	
	// Update is called once per frame
	void Update () {
	

	
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print("Up Arrow Pressed");
			min = guess + 1;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print("Down Arrow Pressed");
			max = guess - 1;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!  Play again?  Y/N");
		}else if (Input.GetKeyDown(KeyCode.Y)) {
			StartGame ();
		}else if (Input.GetKeyDown(KeyCode.N)) {
			Application.Quit();
		}
		
	}
	
	void NextGuess(){
		guess = Random.Range(min, max);
		print ("Is the number higher or lower than " + guess + "?");
		print ("Up = higher, Down = lower, Return = equals");
	}
}
