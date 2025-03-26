using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    [SerializeField] private GameObject plyare;
    [SerializeField] private GameObject camra;
    [SerializeField] private float speed;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 cameraV = new Vector3(camra.transform.position.x,camra.transform.position.y,-10);
        Vector3 playerV = new Vector3(plyare.transform.position.x,plyare.transform.position.y,-10);
        
        transform.position = Vector3.Lerp(cameraV,playerV,1f);
    }
}
