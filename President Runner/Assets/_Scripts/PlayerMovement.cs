using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float SPEED = 5;
    public float STARTING_SPEED = 0.1f;
    private Vector3 movement;
    public bool jump = false;
    private float jumpSpeed = 0;

    private float GRAVITY = 0.2f;
    private float JUMP_SPEED = 0.3f;
    private float SPEED_INCREASE = 0.001f;

	// Use this for initialization
	void Start () {

        movement = new Vector3(0, SPEED, 0);
        SPEED = STARTING_SPEED;

	}
	
	// Update is called once per frame
	void Update () {

        SPEED += (SPEED_INCREASE * Time.deltaTime);

        if (Input.GetKey("up") && !jump)
        {
            jump = true;
            jumpSpeed = JUMP_SPEED;
        }

        if (jump)
        {
            jumpSpeed -= (GRAVITY * Time.deltaTime);
        }
        else
        {
            jumpSpeed = 0;
        }


        movement = new Vector3(SPEED, jumpSpeed, 0);

        transform.position += (movement * Time.deltaTime);

	}
}
