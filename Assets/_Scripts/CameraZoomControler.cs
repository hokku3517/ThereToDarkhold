using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class CameraZoomControler : MonoBehaviour
{
    int sizeNorm = 6;
    int sizeChanged = 12;
    [SerializeField] int cameraMode = 1;
    [SerializeField] GameObject PlayerCamera;
    [SerializeField] TextMeshProUGUI score;

    private Vector3 ogPos;
    private Vector3 newPos;

    private bool canRespawn;
    // Start is called before the first frame update
    void Start()
    {
        PlayerCamera.GetComponent<Camera>().orthographicSize = sizeNorm; // Size u want to start with
        ogPos = gameObject.transform.position;
        newPos = new Vector3(-10000,0,0);
        canRespawn = false;
        score.transform.position = new Vector3(200,0,0);
        //score.transform.position = new Vector3(-93,164,0);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.name.Contains("invis triger") && canRespawn){
            gameObject.transform.position = ogPos;
            canRespawn = false;
        }
    }
    void OnCollisionEnter2D(Collision2D collision) {
		//Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
			if(cameraMode == 1)
			{
				PlayerCamera.GetComponent<Camera>().orthographicSize = Mathf.Lerp(sizeNorm, sizeChanged, Time.deltaTime); // Max size
                gameObject.transform.position = newPos;
                score.transform.position = new Vector3(100,0,0);
                //Destroy(gameObject);
                StartCoroutine(respawn());
			}
			if(cameraMode == 2)
			{
				PlayerCamera.GetComponent<Camera>().orthographicSize = Mathf.Lerp(sizeChanged, sizeNorm, Time.deltaTime); // Min size 
                gameObject.transform.position = newPos;
                score.transform.position = new Vector3(200,0,0);
                //Destroy(gameObject);
                StartCoroutine(respawn());
			}
        }
    }
    IEnumerator respawn(){
        yield return new WaitForSeconds(5f);
        canRespawn = true;
    }
}
