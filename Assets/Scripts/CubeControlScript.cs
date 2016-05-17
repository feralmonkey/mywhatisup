using UnityEngine;
using System.Collections;

public class CubeControlScript : MonoBehaviour {
	// The game object we want to access

	public GameObject target;

	public float a = 1.0f;
	public float b = 1.0f;
	public float c = 1.0f;

	private bool pressed = false;
	private bool zPressed = false;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Cube");
	}
	
	// Update is called once per frame
	void Update () {

		pressed = Input.GetMouseButton (1);
		zPressed = Input.GetMouseButton (0);

		float hVal = Input.GetAxis("Horizontal");
		float vVal = Input.GetAxis("Vertical");

		float mhVal = Input.GetAxis("Mouse X");
		float mvVal = Input.GetAxis("Mouse Y");


		if (hVal != 0)
						target.transform.Translate (hVal, 0f, 0f);
		if (vVal != 0)
						target.transform.Translate (0f, vVal, 0f);

		if (pressed) {
						if (mhVal != 0)
								target.transform.Rotate (0f, mhVal, 0f);
						if (mvVal != 0)
								target.transform.Rotate (mvVal, 0f, 0f);
				}
		if (zPressed) {
						if (mvVal != 0)
								target.transform.Rotate (0f, 0f, mvVal);
				}

		if (Input.GetKey (KeyCode.M)) {
						a += .01f;
						b += .01f;
						c += .01f;
						target.transform.localScale = new Vector3 (a, b, c);
				}

		if (Input.GetKey (KeyCode.N)) {
						a -= .01f;
						b -= .01f;
						c -= .01f;
						target.transform.localScale = new Vector3 (a, b, c);
				}
	}
}
