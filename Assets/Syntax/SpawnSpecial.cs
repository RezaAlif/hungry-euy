using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpecial : MonoBehaviour {
    public SpesialStuff Stuff;
    public GameManager Manager;
    public GameObject[] Senjata;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnMouseDown()
    {
		if(Stuff.Tembak == true)
		{
            Instantiate(Senjata[Stuff.Stuff], transform.position, transform.rotation);
            Manager.Score = 0;
		    Stuff.Tembak = false;
            gameObject.SetActive(false);
		}
    }
}
