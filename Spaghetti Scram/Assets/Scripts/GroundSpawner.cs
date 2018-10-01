using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundSpawner : MonoBehaviour {

    public GameObject groundSprite;

    public void SpawnBlock()
    {
        Instantiate(groundSprite, gameObject.transform.position, Quaternion.identity);
    }
}
