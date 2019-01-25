using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIConfig : MonoBehaviour {
    public float Speed;
    public GameManager Manager;
    Rigidbody2D rb;
	bool Lari;
    AudioSource Kabur;

	// Use this for initialization
	void Start () {
        Manager = GameObject.FindWithTag("Manager").GetComponent<GameManager>();
        Kabur = GameObject.FindWithTag("Kabur").GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(Vector2.right * Speed);

        if (Lari == true)
		{
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if(Manager.Over == true)
        {
            Speed = 0;
        }
        if (Manager.Over == false)
        {
            Speed = 0.05f;
        }
        if (transform.position.x > 9)
        {
            Destroy(gameObject);
        }
	}

    private void OnMouseDown()
    {
        Lari = true;
        Manager.Score += 1;
        Kabur.Play();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Peluru")
        {
            Lari = true;
            Manager.Score += 1;
            Kabur.Play();
        }
    }
}
