using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyAggro : MonoBehaviour
{
    
    [SerializeField]
    public GameObject player;
    [SerializeField]
    private float moveSpeed;
    [SerializeField] 
    private float aggroRange;
//enemies detect friendly
// when my green bean is 20 paces away 
//enemies attack in pattern 1, 2 or 3;
    // Start is called before the first frame update
    void attackPlayer()
    {
        transform.position =
            Vector2.MoveTowards(transform.position, player.transform.position, moveSpeed * Time.deltaTime);
        Debug.Log("attacking");
        
    }
    void Start()
    {
        
    }
    

    // Update is called once per frame
    void Update()
    {
        if (Vector2.Distance(transform.position, player.transform.position) <= aggroRange)
        {
            attackPlayer();
        }
        
    }
}
