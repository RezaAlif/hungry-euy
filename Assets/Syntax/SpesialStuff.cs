using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpesialStuff : MonoBehaviour {
    public int Stuff;
	public bool Tembak;
    public GameObject Spesial;
    public GameManager Manager;
    public GameObject Spawn;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Manager.Score >= 10)
        {
            Spesial.SetActive(true);
        }
        else
        {
            Spesial.SetActive(false);
        }
	}

    public void Bola(int Spesial)
    {
        Stuff = Spesial;
		Tembak = true;
        Spawn.SetActive(true);
    }
}
