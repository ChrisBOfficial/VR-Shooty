using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Spawn : MonoBehaviour
{
    public GameObject enemyPrefab;
    private GameObject enemy;
    private GameObject enemy1;

    // Update is called once per frame
    void Update()
    {
    	if(enemy == null) {
    		enemy = Instantiate(enemyPrefab) as GameObject;
    		enemy.transform.position = new Vector3(3, 1, 3);

    		float angle = Random.Range(0, 360);
    		enemy.transform.Rotate(0, angle, 0);

    		enemy1 = Instantiate(enemyPrefab) as GameObject;
    		enemy1.transform.position = new Vector3(3, 1, 3);

    		float angle1 = Random.Range(0, 360);
    		enemy1.transform.Rotate(0, angle1, 0);
    	}
        
    }
}
