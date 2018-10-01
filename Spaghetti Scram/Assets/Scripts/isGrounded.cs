using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class isGrounded : MonoBehaviour {

    public PlayerMovement playerMove;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        playerMove.isGrounded = true;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        playerMove.isGrounded = false;
    }
}
