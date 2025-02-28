using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject EnemyOffspring;
    [SerializeField] private GameObject hi;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("I spawn forth");
        
        hi = Instantiate(EnemyOffspring, gameObject.transform);
        
        
    }
}
