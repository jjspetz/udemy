using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {

	// global variables
	int max;
	int min;
	int guess;

	// Use this for initialization
	void Start () {
		GameInitialize ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			NextGuess();
		}
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I got it.");
			GameInitialize ();
		}
	}

	void GameInitialize() {
		// reinitilize variables
		min = 0;
		max = 1001;
		guess = 500;

		print ("++++++++++++++++++++++++++++");
		print ("Welcome to Number Wizard.");
		print ("Pick a number, but keep it secret.");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is your number " + guess + "?");
		print ("up arrow for higher, down arrow for lower, return for equal.");
	}

	void NextGuess() {
		guess = (max + min) / 2;
		print ("Higher or lower than " + guess);
		print ("up arrow for higher, down arrow for lower, return for equal.");
	}
}
