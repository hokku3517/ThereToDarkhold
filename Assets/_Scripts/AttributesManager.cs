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
    
    public int autoAmount = 1;
    public int heavyWindAmount = 20;
    public int health = 100;
    public int coinNumber;

    

    [SerializeField] GameObject heart1;
    [SerializeField] GameObject heart2;
    [SerializeField] GameObject heart3;
    [SerializeField] GameObject heart4;

    private PlayerMovement pm;
    private SpriteRenderer SpriteRenderer;
    public int damageCounter = 0;

    [SerializeField] TextMeshProUGUI coinCounter;
    

    public void TakeDamage(int amount)
    {
        if (!pm.canDash || pm.isDashing){
            
        } else if (pm.canDash || !pm.isDashing){
            
            
        }
    }

    public void HandleCollision(Collision2D collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy"))
        {
            if (pm.isDashing)
            {
                if (damageCounter < 3 && collision.gameObject.name.Contains("Sonic"))
                {
                    damageCounter++;
                } else if (!collision.gameObject.name.Contains("Sonic"))
                {
                    Destroy(collision.gameObject);
                } else if (damageCounter >= 3 && collision.gameObject.name.Contains("Sonic"))
                {
                    Destroy(collision.gameObject);
                }
                
                

            }
            else
            {
                {
                   
                }
                health -= autoAmount;
                StartCoroutine(FlashRed());
            }
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
        pm = GetComponent<PlayerMovement>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
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
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
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
