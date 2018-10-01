using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float x = Input.GetAxisRaw("Horizontal");
        gameObject.transform.position += new Vector3(x, 0, 0) * speed * Time.deltaTime;
        if (gameObject.transform.position.x < -9)
        {
            gameObject.transform.position = new Vector3(9,-2, 0);
        }
        if (gameObject.transform.position.x > 9)
        {
            gameObject.transform.position = new Vector3(-9, -2, 0);
        }
	}
}
