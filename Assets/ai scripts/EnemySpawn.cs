using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject EnemyOffspring;
    [SerializeField] private int EnemySpawnAmount;
    
    private Vector3 hi;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //hi = Instantiate(EnemyOffspring, gameObject.transform);
       
    }

    void OnCollisionEnter2D(Collision2D collision) {
		
		//Check for a match with the specified name on any GameObject that collides with your GameObject
        if (collision.gameObject.name == "Player")
        {
            float x = gameObject.transform.position.x;
            float y = gameObject.transform.position.y;
            float z = gameObject.transform.position.z;

            transform.localPosition = new Vector3(x,y,z);

            
            //hi = Instantiate(EnemyOffspring, gameObject.transform);
            for (int i = 0; i < EnemySpawnAmount; i++){
                GameObject.Instantiate(EnemyOffspring, transform.localPosition, Quaternion.identity);
            }
            Destroy(gameObject);
            
        }
        
    }

}
