using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class REBOTE : MonoBehaviour {

    public float bouncySpeed;

	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
	
        this.transform.Translate(0, bouncySpeed, 0);
	}
}
