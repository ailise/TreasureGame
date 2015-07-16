using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class HintScript : MonoBehaviour {

	public Text textUI;
	public Transform player;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (player.position.x < 50f) {
			textUI.text = "Where the hell are you going? Head back left.";
		} else if (player.position.z > 100f) {
			textUI.text = "Now you're cooking with gas.";
		} else if (player.position.x > 100f) {
			textUI.text = "That's the ticket.";
		} else if (player.position.z > 250f) {
			textUI.text = "So close. CAN YOU TASTE IT?!";
		}
	
	}
}
