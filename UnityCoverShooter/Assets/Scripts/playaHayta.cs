using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playaHayta : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("space"))
        {
            Quaternion theAngle = transform.localRotation;
            theAngle.Set(1,1,0,1);
            transform.localRotation = theAngle;
        }
    }
}
