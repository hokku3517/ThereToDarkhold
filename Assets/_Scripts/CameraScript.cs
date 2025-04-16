using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject plyare;
    [SerializeField] private GameObject camra;
    [SerializeField] private float speed;
    private Vector3 cameraV;
    private Vector3 playerV;
    [SerializeField] private float temperDistance;

    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        cameraV = new Vector3(camra.transform.position.x,camra.transform.position.y,-10);
        playerV = new Vector3(plyare.transform.position.x,plyare.transform.position.y,-10);
        Movement();
        
    }
    /*
    public void upDown(){
    //vertical
            if (plyare.transform.position.y - camra.transform.position.y >= 7 || plyare.transform.position.y - camra.transform.position.y <= -7 ){
                transform.position = Vector3.MoveTowards(cameraV,playerV,30f * Time.deltaTime);
            } else if (plyare.transform.position.y - camra.transform.position.y >= 3 || plyare.transform.position.y - camra.transform.position.y <= -3 ){
                transform.position = Vector3.MoveTowards(cameraV,playerV,10f * Time.deltaTime);
            } else {
                transform.position = Vector3.MoveTowards(cameraV,playerV,5f * Time.deltaTime);
            }
    }
    public void leftRight(){
    //horizontal
            if (plyare.transform.position.x - camra.transform.position.x >= 7 || plyare.transform.position.x - camra.transform.position.x <= -7 ){
                transform.position = Vector3.MoveTowards(cameraV,playerV,30f * Time.deltaTime);
            } else if (plyare.transform.position.x - camra.transform.position.x >= 3 || plyare.transform.position.x - camra.transform.position.x <= -3 ){
                transform.position = Vector3.MoveTowards(cameraV,playerV,10f * Time.deltaTime);
            } else {
                transform.position = Vector3.MoveTowards(cameraV,playerV,5f * Time.deltaTime);
            }
    }
    */
    public void Movement(){
    //vertical
            float ypos = plyare.transform.position.y - camra.transform.position.y;
            float xpos = plyare.transform.position.x - camra.transform.position.x;
            if (ypos > temperDistance || ypos < -temperDistance || xpos > temperDistance || xpos < -temperDistance){
                transform.position = Vector3.MoveTowards(cameraV,playerV,30f * Time.deltaTime);
            } else {
                transform.position = Vector3.MoveTowards(cameraV,playerV,10f * Time.deltaTime);
            }
    }
    
}
