using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    
    public int autoAmount = 1;
    public int heavyWindAmount = 20;
    public int health;
    

    public void TakeDamage(int amount)
    {
        health -= amount;
    }

    public void autoDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
           atm.TakeDamage(autoAmount);
        }
    }
    public void HeavyDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            atm.TakeDamage(heavyWindAmount);
        }
    }
    void Start()
    {
        
    }

   
    void Update()
    {
        
    }
}
