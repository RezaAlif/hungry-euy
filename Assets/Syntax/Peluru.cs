using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Peluru : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector3.right * 0.1f);
        if(transform.position.x >= 9)
        {
            Destroy(gameObject);
        }
	}
}
