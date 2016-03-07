﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {
	public int initHealth = 100;
	public int currentHealth;

	public Slider healthSlider;

	// Use this for initialization
	void Start () {
		currentHealth = initHealth;
		healthSlider.value = initHealth;
	}
	
	// Update is called once per frame
	void Update () {
		healthSlider.value = currentHealth;
		Debug.Log("Health: "+ currentHealth);
	}
	void OnCollisionEnter2D(Collision2D isTouchedMe)
	{
		if(isTouchedMe.gameObject.name == "Bullet"){
		currentHealth -= 10;
		}
	}
}
