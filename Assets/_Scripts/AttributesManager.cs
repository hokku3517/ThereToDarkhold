using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.SceneManagement;

public class AttributesManager : MonoBehaviour
{
    
    private int autoAmount = 1;
    private int heavyWindAmount = 20;
    public int health;
    public int coinNumber;
    
    

    

    [SerializeField] GameObject heart1;
    [SerializeField] GameObject heart2;
    [SerializeField] GameObject heart3;
    [SerializeField] GameObject heart4;

    private PlayerMovement pm;
    private SpriteRenderer SpriteRenderer;
    public int damageCounter = 0;

    [SerializeField] TextMeshProUGUI coinCounter;
    

    public void TakeDamage(String name, int amount)
    {
        Debug.Log("I got called and my health is " + health);
        if (name.Contains(name)){
            /*
                Debug.Log("I got my name checked and it is valid"); 
                Debug.Log("If it worked my health was" + health);

                Debug.Log(" and is now" + health);
            */
            
        }
    }

    public void HandleCollision(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
            if (pm.isDashing)
            {
                if (damageCounter < 3 && collision.gameObject.name.Contains("Sonic"))
                {
                    damageCounter++;
                } else if (!collision.gameObject.name.Contains("Sonic"))
                {
                    //Destroy(collision.gameObject);
                } else if (damageCounter >= 3 && collision.gameObject.name.Contains("Sonic"))
                {
                    //Destroy(collision.gameObject);
                }
            }
            else
            {
                //health -= autoAmount;
                StartCoroutine(FlashRed());
            }
        }
    

    public IEnumerator FlashRed()
    {
        Debug.Log("Should Flash");
        SpriteRenderer.color= Color.red;
        yield return new WaitForSeconds(.1f);
        SpriteRenderer.color = Color.white;
    }

    public void autoDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
           //atm.TakeDamage(autoAmount);
        }
    }

    public void HeavyDamage(GameObject target)
    {
        var atm = target.GetComponent<AttributesManager>();
        if (atm != null)
        {
            //atm.TakeDamage(heavyWindAmount);
        }
    }
   
    void Start()
    {
        pm = GetComponent<PlayerMovement>();
        SpriteRenderer = GetComponent<SpriteRenderer>();

        health = 100;
    }
    


    void Update()
    {
        
        if(gameObject.name == "Player"){
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
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        } else if (gameObject.name.Contains("Square")){
            if (health <= 0){
                Destroy(gameObject);
            }
            
        }
        
        
    }
    
    void OnCollisionEnter2D(Collision2D collision) {
        HandleCollision(collision);
    }

    public void IncreaseCoins()
    {
        Debug.Log("Should go up in coinage");
        coinNumber++;
        coinCounter.text = "" + coinNumber;
    }
    
}
