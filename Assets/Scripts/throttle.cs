using UnityEngine;
using System.Collections;

public class throttle : MonoBehaviour {

	Animator anim;

	public kiteControl kite;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			Debug.Log("ini sentuhan");
			kite.gas();
		}
	}
}
