using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour {
    public int List;
    public int LV;

	// Use this for initialization
	void Start () {
		LV = PlayerPrefs.GetInt("PlayerPrefs_LEVEL");
    }
	
	// Update is called once per frame
	void Update () {
		if(LV < List)
        {
            gameObject.SetActive(false);
        }
	}
}
