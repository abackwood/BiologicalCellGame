using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraPlayerTracking : MonoBehaviour {
    public Transform playerTransform;

    public Vector3 velocity;

	// Use this for initialization
	void Start () {
        velocity = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 difference = playerTransform.position - transform.position;
        transform.position = Vector3.SmoothDamp(transform.position, playerTransform.position, ref velocity, 0.5f);
	}
}
