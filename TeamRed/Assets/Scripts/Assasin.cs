﻿using UnityEngine;
using System.Collections;

public class Assasin : Character {

    public override void startVariables()
    {
        maxHealth = 5;
        currentHealth = maxHealth;
        maxMove = 9;
        maxAction = 1;
        costPerAction = 1;
        costPerMovement = 3;
        damage = 25;
        attackRange = 1;

    }

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}