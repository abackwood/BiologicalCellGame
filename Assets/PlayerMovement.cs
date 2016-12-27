using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float moveSpeed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 moveDelta = Vector3.zero;
        if(Input.GetKey(KeyCode.W)) {
            moveDelta += Vector3.forward;
        }

        if(Input.GetKey(KeyCode.S)) {
            moveDelta += Vector3.back;
        }

        if(Input.GetKey(KeyCode.A)) {
            moveDelta += Vector3.left;
        }

        if(Input.GetKey(KeyCode.D)) {
            moveDelta += Vector3.right;
        }

        transform.position += moveDelta.normalized * moveSpeed * Time.deltaTime;
	}
}
