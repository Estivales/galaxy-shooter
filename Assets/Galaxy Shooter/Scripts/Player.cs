﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public GameObject laserPrefeb;

    [SerializeField]
    private float speed = 7.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        Movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(laserPrefeb, new Vector3(transform.position.x, transform.position.y + 0.88f, 0), Quaternion.identity);
        }
    }
    
    private void Movement()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.right * Time.deltaTime * speed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * speed * verticalInput);


        if (transform.position.y < -4.2f)
        {

            transform.position = new Vector3(transform.position.x, -4.2f, 0);
        }

        if (transform.position.y > 4.2f)
        {

            transform.position = new Vector3(transform.position.x, 4.2f, 0);
        }

        if (transform.position.x < -8.2f)
        {

            transform.position = new Vector3(-8.2f, transform.position.y, 0);
        }

        if (transform.position.x > 8.2f)
        {

            transform.position = new Vector3(8.2f, transform.position.y, 0);
        }
    }
        
}

