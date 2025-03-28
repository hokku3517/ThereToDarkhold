using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttackUniversal : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private GameObject AttackAreaObject;
    [SerializeField] private GameObject Area;
    
    // Start is called before the first frame update
    void Start()
    {
        
        //Debug.Log("I need an area");
        Area = Instantiate(AttackAreaObject);
        
    }

    // Update is called once per frame
    void Update()
    {
        int x = 1;
        Vector3 pos = transform.position;
        if (x == 1) {
            Area.transform.position = pos;
            x++;
        }

        
    }

    
}
