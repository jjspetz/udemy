using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets, locks, freedom};
	private States myState;
	private string inventory = "";
//	List<string> inventory = new List<string>();

	// Use this for initialization
	void Start () {
		myState = States.cell;
	}

	// Update is called once per frame
	void Update () {
		print (myState);
		if (myState == States.cell) {
			cell ();
		} else if (myState == States.sheets) {
			sheets ();
		} else if (myState == States.mirror) {
			mirror ();
		} else if (myState == States.locks) {
			locks ();
		} else if (myState == States.freedom) {
			freedom ();
		}
	}

	void cell() {

		if (inventory == "sheets") {
			text.text = "You are in a cell. There is a lock on the door, A mirror on the wall, " +
			"and dirty sheets in your hand.\n\n" +
			"Press M to view mirror, or L to view the lock.";
		} else if (inventory == "mirror") {
			text.text = "You are in a cell. There is a lock on the door, A mirror in your hand, " +
			"and dirty sheets on the bed.\n\n" +
			"Press S to view sheets or L to view the lock.";
		} else {
			text.text = "You are in a cell. There is a lock on the door, A mirror on the wall, " +
				"and dirty sheets on the bed.\n\n" +
				"Press S to view sheets, M to view mirror, or L to view the lock.";
		}

		if (Input.GetKeyDown (KeyCode.S) && inventory != "sheets") {
			myState = States.sheets;
		} else if (Input.GetKeyDown (KeyCode.M) && inventory != "mirror") {
			myState = States.mirror;
		} else if (Input.GetKeyDown (KeyCode.L)) {
			myState = States.locks;
		}
	}

	void sheets() {
		text.text = "There are dirty sheets on your bed. \n\n";

		if (inventory == "") {
			text.text += "Press T to take the sheets. ";
		} else {
			text.text += "Press T to take the sheets, and drop the " + inventory + ". ";
		}
		text.text += "Press R to return.";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			inventory = "sheets";
			myState = States.cell;
		}
	}

	void mirror() {
		text.text = "The mirror is cracked. You don't look good. \n\n";

		if (inventory == "") {
			text.text += "Press T to take the mirror. ";
		} else {
			text.text += "Press T to take the mirror, and drop the " + inventory + ". ";
		}
		text.text += "Press R to return.";

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.T)) {
			inventory = "mirror";
			myState = States.cell;
		}
	}

	void locks() {

		if (inventory == "sheets") {
			text.text = "The sheets don't seem to help you open the lock.\n\n" +
				"Press R to return.";
		} else if (inventory == "mirror") {
			text.text = "You use the mirror to see the buttons. Greasy finger prints give away the code.\n\n" +
				"Press R to return or O to open the door.";
		} else {
			text.text = "The lock is a push button lock. If only you could see the buttons\n\n" +
				"Press R to return.";
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			myState = States.cell;
		} else if (Input.GetKeyDown (KeyCode.O) && inventory == "mirror") {
			myState = States.freedom;
		}
	}

	void freedom() {
		text.text = "Congratulations, You've gained your freedom.\n\n" +
					"Game Over";
	}
}
