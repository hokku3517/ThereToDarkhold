using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;
using UnityEngine.Serialization;

public class LoS : MonoBehaviour
{
    [FormerlySerializedAs("player")] [SerializeField] [NotNull]
    public GameObject attached;

    [SerializeField] private float speed;
    [SerializeField] public GameObject player;

    private bool hasLineOfSight;
    private float distanceToAttached;

    [SerializeField] private float aggroRange;

    // Start is called before the first frame update
    void Start()
    {
        attached = GameObject.FindGameObjectWithTag("Friend");
    }

    // Update is called once per frame
    void Update()
    {
        if (hasLineOfSight)
        {
            transform.position =
                Vector2.MoveTowards(transform.position, attached.transform.position, speed * Time.deltaTime);
        }
    }

    private void FixedUpdate()
    {
        float distanceToAttached = Vector2.Distance(transform.position, attached.transform.position);
        if (distanceToAttached <= aggroRange)
        {
            RaycastHit2D ray = Physics2D.Raycast(transform.position, player.transform.position - transform.position);
            if (ray.collider != null)
            {
                hasLineOfSight = ray.collider.CompareTag("Friend");
                if (ray.collider.CompareTag("obsticale"))
                {
                    
                }
                    
                
                
                    
                if (hasLineOfSight)
                {
                    Debug.DrawRay(transform.position, attached.transform.position - transform.position, Color.green);
                    Debug.Log("im working");
                }
                else
                {
                    hasLineOfSight = false;
                    Debug.DrawRay(transform.position, attached.transform.position - transform.position, Color.red);
                    Debug.Log("ME 2");
                }

            }
        }
    }
}