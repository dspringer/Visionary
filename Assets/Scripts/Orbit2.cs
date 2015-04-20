using UnityEngine;
using System.Collections;

public class Orbit2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Vector3 camAngle = new Vector3 (40, -90, 0);
		transform.RotateAround (GameObject.FindGameObjectWithTag ("Player").transform.position, camAngle, 20 * Time.deltaTime);
	}
}
