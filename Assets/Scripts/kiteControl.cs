using UnityEngine;
using System.Collections;

public class kiteControl : MonoBehaviour {

	Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			this.rotasi ();
		} else if (Input.GetKey (KeyCode.E)) {
			this.gas ();
		} else {
			this.turun ();
		}
	}

	public void gas() {
		transform.Translate(0, 0.2f, 0);
	}

	public void rotasi() {
		transform.Rotate(0, 0, 10);
	}

	public void turun() {
		transform.Translate(0, -0.1f, 0);
	}
}
