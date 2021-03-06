﻿using UnityEngine;
using System.Collections;

public class ScrollingObject : MonoBehaviour {

	public PlayerController thePlayer;
	private Rigidbody2D rb2d;

	// Use this for initialization
	void Start () {
		rb2d = GetComponent<Rigidbody2D> ();
		thePlayer = FindObjectOfType<PlayerController> ();
		rb2d.velocity = new Vector2 (GameControl.instance.GetScrollSpeed(),0f);
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.instance.gameOver == true) {
			rb2d.velocity = Vector2.zero;
		}
		rb2d.velocity = new Vector2 (GameControl.instance.GetScrollSpeed(),0f);
	}
}
