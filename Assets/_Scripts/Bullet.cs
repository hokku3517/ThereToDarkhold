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
        Destroy(gameObject);
        if (collision.gameObject.name.Contains("Square"))
            {
                //Destroy(collision.gameObject);
                collision.gameObject.GetComponent<AttributesManager>().health -= 25;
                //am.TakeDamage(collision.gameObject.name, 2);s
                    
                    
                //am.TakeDamage("Square", 25);
            } else if (collision.gameObject.name.Contains("FreakyBoss"))
            {
               collision.gameObject.GetComponent<AttributesManager>().health -= 25;
            }
        
            
        
    }
}
