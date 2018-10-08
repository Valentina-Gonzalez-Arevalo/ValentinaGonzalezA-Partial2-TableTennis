using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftRacket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
        if (Input.GetKey(KeyCode.W))
        { this.transform.Translate(Vector3.down * 0.2f); }


        if (Input.GetKey(KeyCode.S))
        { this.transform.Translate(Vector3.up * 0.2f); }

        if (Input.GetKey(KeyCode.A))
        { this.transform.Translate(Vector3.left * 0.2f); }

        if (Input.GetKey(KeyCode.D))
        { this.transform.Translate(Vector3.right * 0.2f); }
	}
}
