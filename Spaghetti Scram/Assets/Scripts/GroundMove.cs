using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundMove : MonoBehaviour {

    public float travelSpeed;
    public GroundSpawner spawner;
    bool destroy;

	// Use this for initialization
	void Start () {
        spawner = GameObject.Find("GroundSpawner").GetComponent<GroundSpawner>();
	}
	
	// Update is called once per frame
	void Update () {

        gameObject.transform.position += new Vector3(travelSpeed * Time.deltaTime, 0);

        if(gameObject.transform.position.x > 40 || gameObject.transform.position.x < -40)
        {
            destroy = true;
            Destroy(gameObject);
        }

	}

    void OnDestroy()
    {
        try
        {
            if (destroy == true)
            {
                spawner.SpawnBlock();
            }
        }
        catch { }

    }
}
