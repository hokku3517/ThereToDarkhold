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
        
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    
    void OnCollisionEnter2D(Collision2D collision) {
		
		//Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            //If the GameObject's name matches the one you suggest, output this message in the console
            Debug.Log("Colliding with: " + _player);
            
        }

        //Check for a match with the specific tag on any GameObject that collides with your GameObject
        if (collision.gameObject.tag == "Friend")
        {
            //If the GameObject has the same tag as specified, output this message in the console
            Debug.Log("Colliding with: " + _player);
            
        }
    }
    
    
    
}
