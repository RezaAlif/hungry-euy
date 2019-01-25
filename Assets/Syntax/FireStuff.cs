using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireStuff : MonoBehaviour {
    float Timing;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Timing += Time.deltaTime;
        if(Timing >= 5)
        {
            Destroy(gameObject);
        }
	}
}
