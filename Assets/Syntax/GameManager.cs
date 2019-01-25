using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {
    public float Timing;
    public GameObject Completed;
    public float Score;
    public bool Over;
    public Image Waktu;
    public int Level;
    public AudioSource Beres;

	// Use this for initialization
	void Start ()
    {
        Time.timeScale = 1;
    }
	
	// Update is called once per frame
	void Update () {
        Timing -= Time.deltaTime;
        Waktu.fillAmount = Timing/60f;
        if (Timing <= 0)
        {
            Completed.SetActive(true);
            Time.timeScale = 0;
            Over = true;
            Beres.Play();
            PlayerPrefs.SetInt("PlayerPrefs_LEVEL",Level);
        }
	}

    public void Pindah(string Lv)
    {
        Application.LoadLevel(Lv);
    }

    public void Pagar()
    {
        Score -= 5;
    }

    public void Kasti()
    {
        Score -= 5;
    }

    public void Selang()
    {
        Score -= 5;
    }

    public void Api()
    {
        Score -= 5;
    }

    //pause
    public void Pause(GameObject Paused)
    {
        Paused.SetActive(true);
        Time.timeScale = 0;
        Over = true;
    }

    public void Resume(GameObject Paused)
    {
        Paused.SetActive(false);
        Time.timeScale = 1;
        Over = false;
    }
}
