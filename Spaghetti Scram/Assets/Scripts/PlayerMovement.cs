using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    Rigidbody2D rigid;
    public float jumpForce;
    public bool isGrounded;

	// Use this for initialization
	void Start () {

        rigid = gameObject.GetComponent<Rigidbody2D>();
	}
	
    void Update()
    {

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            Debug.Log("Hit Jump");
            rigid.AddForce(gameObject.transform.up * jumpForce);
        }
    }

}
