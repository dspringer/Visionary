using UnityEngine;
using System.Collections;

public class Pulse : MonoBehaviour {

	public GameObject p;
	public Vector3 scaleVec = new Vector3(1f,1f, 1f);
	public Vector3 incVec = new Vector3(.25f, .25f, .25f);
	// Use this for initialization
	void Start () {

		//InvokeRepeating ("Shrink", 0, 1.0f);
		//InvokeRepeating ("Grow", 0, 1.0f);
	}
	
	// Update is called once per frame
	void Update () {
		//int sysSec = System.DateTime.Now.Second;
		int sysMilSec = System.DateTime.Now.Millisecond;

		if ((sysMilSec % 5) == 0)
						Shrink ();
		if ((sysMilSec % 2) == 1)
						Grow ();

	}

	void Shrink() {
		p = GameObject.FindGameObjectWithTag ("Player");
		//scaleVec = (1f, 1f, 1f);
		scaleVec.x = 1f;
		scaleVec.y = 1f;
		scaleVec.z = 1f;
		p.transform.localScale = scaleVec;
		//p.transform.localScale = new Vector3 (1f, 1f, 1f);
	}

	void Grow() {
		p = GameObject.FindGameObjectWithTag ("Player");

		scaleVec = scaleVec + incVec;
		p.transform.localScale = scaleVec;

		//p.transform.localScale = new Vector3 (1f, 1f, 1f);
		//p.transform.localScale = new Vector3 (1.25f, 1.25f, 1.25f);

	}

}