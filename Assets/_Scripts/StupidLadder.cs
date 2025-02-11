using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StupidLadder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionStay(Collision collision) {
		GameObject otherObj = collision.gameObject;
		Debug.Log("Collided with: " + otherObj);
        otherObj.transform.Translate(0,1,0);
    }
}

