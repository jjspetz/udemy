using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour {
	
	// global variables
	int max = 1000;
	int min = 1;
	int guess = 500;

	// Use this for initialization
	void Start () {
		print ("Welcome to Number Wizard.");
		print ("Pick a number, but keep it secret.");

		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);

		print ("Is your number " + guess + "?");
		print ("up arrow for higher, down arrow for lower, 
return for equal.");

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			min = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess);
		}
		else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			max = guess;
			guess = (max + min) / 2;
			print ("Higher or lower than " + guess);
		}
		else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I got it.");
		}
	}
}
