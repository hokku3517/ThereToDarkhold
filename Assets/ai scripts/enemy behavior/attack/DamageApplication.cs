using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageApplication : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedOnCollisionEnter2D(Collision2D collision) {
		
		//Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
           Debug.Log("my name is jamar");
            
        }
        
    }
}
