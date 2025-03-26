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

        
        
        transform.position = Vector3.lerp(camra.position,plyare.position,1f);
    }
}
