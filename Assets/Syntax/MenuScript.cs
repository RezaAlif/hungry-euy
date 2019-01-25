using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {
    public GameObject Menu;
    public GameObject Load;
	public GameObject Level;

    public string[] scene;
    public string[] detail;
    public string Arena;

    public Text detailUI;

    public bool play;
    public float loading;

	// Use this for initialization
	void Start () {

    }
	
	// Update is called once per frame
	void Update ()
    {
        if(play == true)
        {
            Load.SetActive(true);
            Level.SetActive(false);
            loading += Time.deltaTime;
        }
        if(loading >= 3)
        {
            Application.LoadLevel(Arena);
        }
	}

    public void Pindah(int Level)
    {
        play = true;
        detailUI.text = detail[Level];
        Arena = scene[Level];
    }

    public void Pilih(GameObject Chapter)
    {
        Menu.SetActive(false);
        Chapter.SetActive(true);
    }

    public void Back(GameObject Chapter)
    {
        Menu.SetActive(true);
        Chapter.SetActive(false);    }

    public void Active(GameObject Object)
    {
        Object.SetActive(true);
        Menu.SetActive(false);
    }

    public void Keluar()
    {
        Application.Quit();
    }
 }
