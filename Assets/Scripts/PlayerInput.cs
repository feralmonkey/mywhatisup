using UnityEngine;
using System.Collections;

public class PlayerInput : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float hVal = Input.GetAxis("Horizontal");
		float vVal = Input.GetAxis("Vertical");

		if (hVal != 0) {
			print ("Horizontal Movement Selected: " + hVal);
				}
		if (vVal != 0) {
			print ("Vertical Movement Selected: " + vVal);		
				}
	}
}
