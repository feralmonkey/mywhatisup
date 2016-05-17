using UnityEngine;
using System.Collections;

public class CubeScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate (.05f, 0f, 0f);
		transform.Rotate (0f, 0f, 1f);
		transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
	}
}
