using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubelerp : MonoBehaviour {

    public Vector3 startpos;
    public Vector3 endpos;
    public float moveDuration = 5.0f;
    private float startTime;

	// Set startTime to seconds since start of game, startpos to cube's position
	void Start () {
        startTime = Time.time;
        startpos = this.transform.position;
        endpos = new Vector3(0, 5, 5);
        StartCoroutine(moveCube());	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    // Coroutine to move cube over a set duration
    IEnumerator moveCube()
    {
        float i = startTime;
        float speed = 1.0f / moveDuration;
        while (i < 1.0f )
        {
            i += Time.deltaTime * speed;
            this.transform.position = Vector3.Lerp(startpos, endpos, i);
            yield return null;
        }
    }
}
