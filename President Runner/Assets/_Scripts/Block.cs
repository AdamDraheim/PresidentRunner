using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour {

    private GameObject player;

	// Use this for initialization
	void Start () {
		
        if(player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
	}
	
	// Update is called once per frame
	void Update () {

        if (player.transform.position.x - transform.position.x < -500)
        {
            transform.position = new Vector3(500, 0, 0);
        }

	}
}
