using UnityEngine;
using System.Collections;

public class PlayerInput2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.M))
						print ("The 'M' key is pressed down");
	}
}
