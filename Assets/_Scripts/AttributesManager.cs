using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    
    public int damageAmount = 10;

    public int health;
    

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public void DealDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
           atm.TakeDamage(damageAmount);
        }
    }
    
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
