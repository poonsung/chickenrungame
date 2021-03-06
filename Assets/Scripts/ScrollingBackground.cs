﻿using UnityEngine;
using System.Collections;

public class ScrollingBackground : MonoBehaviour {
	
	private PlayerController thePlayer;
	private Rigidbody2D rb2d;
	private SpriteRenderer sr;

	// Use this for initialization
	void Start () {
		thePlayer = FindObjectOfType<PlayerController> ();
		rb2d = GetComponent<Rigidbody2D> ();
		sr = GetComponent<SpriteRenderer> ();
		BackgroundMove ();
	}

	// Update is called once per frame
	void Update () {
		if (GameControl.instance.gameOver == true) {
			rb2d.velocity = Vector2.zero;
		}
		BackgroundMove ();
	}

	public void BackgroundMove(){
		if (sr.sortingOrder == 1 ){
			rb2d.velocity = new Vector2 (GameControl.instance.GetScrollSpeed() * 0.2f,0f);
		}
		else if (sr.sortingOrder == 2 ){
			rb2d.velocity = new Vector2 (GameControl.instance.GetScrollSpeed() * 0.4f,0f);
		}
		else if (sr.sortingOrder == 3 ){
			rb2d.velocity = new Vector2 (GameControl.instance.GetScrollSpeed() * 0.6f,0f);
		}
		else if (sr.sortingOrder == 4 ){
			rb2d.velocity = new Vector2 (GameControl.instance.GetScrollSpeed() * 0.8f,0f);
		}
		else if (sr.sortingOrder == 5 ){
			rb2d.velocity = new Vector2 (GameControl.instance.GetScrollSpeed() * 1f,0f);
		}
	}

}
