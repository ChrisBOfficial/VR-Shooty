using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class playerInfo : MonoBehaviour
{
	private int _health;

    // Start is called before the first frame update
    void Start()
    {
    	_health = 5;
    }

    public void Hurt(int damage) {
    	_health -= damage;
    	Debug.Log("Hit");
    	if(_health <= 0) {
    		Application.LoadLevel("GameOverScene");
    	}
    }

}
