using UnityEngine;
using System.Collections;

public class TargetCubeScript : MonoBehaviour {
	// This is the game object you want to access
	public GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Cube");
	}
	
	// Update is called once per frame
	void Update () {
		target.transform.Translate(.05f, 0f, 0f);
		target.transform.Rotate (0f, 0f, 1f);
		target.transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
	}
}
