﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject enemy;

    // Update is called once per frame
    void Update()
    {
    	if(enemy == null) {
    		enemy = Instantiate(enemyPrefab) as GameObject;
    		enemy.transform.position = new Vector3(3, 1, 3);

    		float angle = Random.Range(0, 360);
    		enemy.transform.Rotate(0, angle, 0);
    	}
        
    }
}
