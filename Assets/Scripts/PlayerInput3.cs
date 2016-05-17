using UnityEngine;
using System.Collections;

public class PlayerInput3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float mxVal = Input.GetAxis ("Mouse X");
		float myVal = Input.GetAxis ("Mouse Y");

		if (mxVal != 0)
						print ("Mouse X Movement Selected: " + mxVal);
		if (myVal != 0)
						print ("Mouse Y Movement Selected: " + myVal);

	}
}
