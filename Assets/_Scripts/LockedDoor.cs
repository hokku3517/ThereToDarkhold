using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedDoor : MonoBehaviour
{
    [SerializeField] GameObject _player;
	SpriteRenderer _sprRend;

    // Start is called before the first frame update
    void Start()
    {
        _sprRend = gameObject.GetComponent<SpriteRenderer>();
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space")){
            _sprRend.enabled = false;
        } else if (!Input.GetKeyDown("space")){
            _sprRend.enabled = true;
        }
    }
    
    
    void OnCollisionEnter(Collision collision) {
		
		//Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Colliding with: " + _player);
            _sprRend.enabled = false;
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Friend")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Colliding with: " + _player);
            _sprRend.enabled = false;
        }
    }
    void OnCollisionExit(Collision collision) {
		//Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("No longer colliding with: " + _player);
            _sprRend.enabled = true;
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Friend")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("No longer colliding with: " + _player);
            _sprRend.enabled = true;
        }
        
    }
    
    
}
