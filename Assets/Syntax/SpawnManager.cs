using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {
    public float[] MaxTime;
    public float Timing;
    public GameObject Musuh;
    public int Urutan;
    public int Max;

	// Use this for initialization
	void Start () {
        Urutan = Random.Range(0, Max);
    }
	
	// Update is called once per frame
	void Update () {
        Timing += Time.deltaTime;
        if(Timing >= MaxTime[Urutan])
        {
            Urutan = Random.Range(0, Max);
            Timing = 0;
            Instantiate(Musuh, transform.position, transform.rotation);
        }
	}
}
