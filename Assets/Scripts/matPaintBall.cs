using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class matPaintBall : MonoBehaviour
{
	public float speed = 10.0f;
	public int damageNum = 1;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }

    void OnTriggerEnter(Collider other) {
    	playerInfo player = other.GetComponent<playerInfo>();

    	if(player != null) {
    		player.Hurt(damageNum);
    	}
    	Destroy(this.gameObject);

    }
}
