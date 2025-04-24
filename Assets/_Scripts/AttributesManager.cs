using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttributesManager : MonoBehaviour
{
    
    public int autoAmount = 1;
    public int heavyWindAmount = 20;
    public int health = 100;

    [SerializeField] GameObject heart1;
    [SerializeField] GameObject heart2;
    [SerializeField] GameObject heart3;
    [SerializeField] GameObject heart4;

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

        if (health > 75 && health <= 100){
            //4hearts do nothing
        } else if (health > 50 && health <= 75){
            //3 heartts delete heart 4
            Destroy(heart4);
        } else if (health > 25 && health <= 50){
            //2 heartts delete heart 3
            Destroy(heart3);
            Destroy(heart4);
        } else if (health > 1 && health <= 25){
            //1 heartts delete heart 2
            Destroy(heart2);
            Destroy(heart3);
            Destroy(heart4);
        } else if (health < 1){
            //0 hearts delete heart 1
            Destroy(heart1);
            Destroy(heart2);
            Destroy(heart3);
            Destroy(heart4);
        }
    }
}
