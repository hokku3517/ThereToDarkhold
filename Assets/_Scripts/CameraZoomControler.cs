using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZoomControler : MonoBehaviour
{
    int sizeNorm = 6;
    int sizeChanged = 12;
    [SerializeField] int cameraMode = 1;
    [SerializeField] GameObject PlayerCamera;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera.GetComponent<Camera>().orthographicSize = sizeNorm; // Size u want to start with
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter2D(Collision2D collision) {
		
		//Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            
			if(cameraMode == 1)
			{
				PlayerCamera.GetComponent<Camera>().orthographicSize = Mathf.Lerp(sizeNorm, sizeChanged, Time.deltaTime); // Max size
                Destroy(gameObject);
			}
            
			if(cameraMode == 2)
			{
				PlayerCamera.GetComponent<Camera>().orthographicSize = Mathf.Lerp(sizeChanged, sizeNorm, Time.deltaTime); // Min size 
                Destroy(gameObject);
			}
            
        }

        
    }
}
