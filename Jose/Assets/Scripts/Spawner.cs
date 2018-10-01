using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject obstacle1;
    public Transform[] spawnPoints;
    public float speed;


	// Use this for initialization
	void Start () {
        SpawnObject();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void SpawnObject()
    {

        GameObject tempObject = Instantiate(obstacle1, spawnPoints[0].position, Quaternion.identity);
        tempObject.GetComponent<ObstacleMove>().speed = speed;
    }

}
