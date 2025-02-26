using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class PlayerAttack : MonoBehaviour
{
   private float timeBetweenAttack;
   public float startTimeBetweenAttack;

   public Transform attackPos;
   public float attackRange;
   public LayerMask whatIsEnemies;
   public int damage;
   
   private void Update()
   {
      if (timeBetweenAttack <= 0)
      {
         if (Input.GetKey(KeyCode.Mouse1))
         {
            // if (collision.gameObject.name == "x"
            // {
            // Debug.Log("Colliding with : " + x);
            // Destroy(gameObject);
         }
         
         timeBetweenAttack = startTimeBetweenAttack;
      }
      else
      {
         timeBetweenAttack -= Time.deltaTime;
      }
   }
}
