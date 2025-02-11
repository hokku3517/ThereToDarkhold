using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyScript : MonoBehaviour
{
    [SerializeField] GameObject _player;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    void OnCollisionEnter(Collision collision) {
		
		//Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Colliding with: " + _player);
            //_sprRend.enabled = false;
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Friend")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Colliding with: " + _player);
            //_sprRend.enabled = false;
        }
    }

    void OnCollisionStay (Collision other)
    {
        Debug.Log ("A collider is in contact with the DoorObject Collider");
    }
    
    void OnCollisionExit (Collision other)
    {
        Debug.Log ("A collider has ceased contact with the DoorObject Collider");
    }



}
