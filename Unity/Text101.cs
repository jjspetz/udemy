using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour {

	public Text text;
	private enum States {cell, mirror, sheets, locks};
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
		}
	}

	void cell() {
		text.text = "You are in a cell. There is a lock on the door, A mirror on the wall, " +
		"and dirty sheets on the bed.\n\n" +
		"Press S to view sheets, M to view mirror, or L to view the lock.";

		if (inventory == "sheets") {
			text.text = "You are in a cell. There is a lock on the door, A mirror on the wall, " +
				"and dirty sheets in your hand.\n\n" +
				"Press M to view mirror, or L to view the lock.";
		} else if (inventory == "mirror") {
			text.text = "You are in a cell. There is a lock on the door, A mirror in your hand, " +
				"and dirty sheets on the bed.\n\n" +
				"Press S to view sheets or L to view the lock.";
		}

		if (Input.GetKeyDown (KeyCode.S)) {
			myState = States.sheets;
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
}
