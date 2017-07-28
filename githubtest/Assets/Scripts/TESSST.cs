using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESSST : MonoBehaviour {


    Rigidbody rb;

	// Use this for initialization
	void Start () {
        rb = this.GetComponent<Rigidbody>();
        rb.useGravity = false;
        rb.AddForce(50f, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
