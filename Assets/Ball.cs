﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, 5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.collider.tag == "Player") {
            Debug.Log("Hit Pad");
            rb.velocity = new Vector2((transform.position.x - collision.collider.transform.position.x)* 2, rb.velocity.y);
        }
    }
}
