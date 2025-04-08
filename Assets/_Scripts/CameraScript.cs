using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject plyare;
    [SerializeField] private GameObject camra;
    [SerializeField] private float speed;
    

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraV = new Vector3(camra.transform.position.x,camra.transform.position.y,-10);
        Vector3 playerV = new Vector3(plyare.transform.position.x,plyare.transform.position.y,-10);
        
        if (plyare.transform.position.x - camra.transform.position.x >= 7 || plyare.transform.position.x - camra.transform.position.x <= -7 ){
            transform.position = Vector3.MoveTowards(cameraV,playerV,30f * Time.deltaTime);
        } else if (plyare.transform.position.x - camra.transform.position.x >= 3 || plyare.transform.position.x - camra.transform.position.x <= -3 ){
            transform.position = Vector3.MoveTowards(cameraV,playerV,10f * Time.deltaTime);
        } else {
            transform.position = Vector3.MoveTowards(cameraV,playerV,5f * Time.deltaTime);
        }
    }
}
