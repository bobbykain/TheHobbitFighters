using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OriHealth : MonoBehaviour {
	public float CurrentHealth { get; set; }
	public float MaxHealth { get; set; }

	public Slider healthBar;

	// Use this for initialization
	void Start () {
		MaxHealth = 20f;
		CurrentHealth = MaxHealth;
		healthBar.value = CalculateHealth();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown(0)) {
			DealDamage(2);
		}
	}

	void DealDamage(float damageValue) {
		// Deduce the damage dealt from the character's health
		CurrentHealth -= damageValue;
		healthBar.value = CalculateHealth();
		// If the character is out of health, die!
		if (CurrentHealth <= 0) {
			Die();
		}
	}

	float CalculateHealth() {
		return CurrentHealth / MaxHealth;
	}

	void Die() {
		CurrentHealth = 0;
		Debug.Log("you dead");
	}
}
