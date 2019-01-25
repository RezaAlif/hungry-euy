using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Batas : MonoBehaviour {
    public GameManager Manager;
    public GameObject GameOver;
    public AudioSource Gagal;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            GameOver.SetActive(true);
            Time.timeScale = 0;
            Manager.Over = true;
            Cursor.visible = true;
            Gagal.Play();
        }
    }
}
