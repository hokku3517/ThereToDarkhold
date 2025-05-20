using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private int timeToDespawn;
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExampleCoroutine());
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ExampleCoroutine()
    {
        yield return new WaitForSeconds(timeToDespawn);
        if (gameObject.name != "Bullet"){
            Destroy(gameObject);
        }

        
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        
        //collision.gameObject.GetComponent<AttributesManager>().health -= 25;
            if (collision.gameObject.name.Contains("FreakySquare"))
            {
                collision.gameObject.GetComponent<AttributesManager>().health -= 25;
                
            } else if (collision.gameObject.name.Contains("FreakyBoss"))
            {
               collision.gameObject.GetComponent<AttributesManager>().health -= 25;
               
            }   
        Destroy(gameObject);
        
    }
}
