using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{
    
    
    [SerializeField] private GameObject SecondAmmendment;
    [SerializeField] private GameObject Player;

    [SerializeField] private GameObject Bullet;
    [SerializeField] private Rigidbody2D BulletRigidbody;

    private float mouseX;
    private float mouseY;

    [SerializeField] private int bulletSpeed = 100;

    float angle;

    GameObject instance;

    
    // Start is called before the first frame update
    void Start()
    {
        BulletRigidbody = Bullet.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        RotationLogic();
        ShootingLogic();
    }

    void RotationLogic(){
        Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5.23f;

		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;

		angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));


        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, 0);
        
        if (angle >= 90 || angle <= -90){
            SecondAmmendment.transform.localScale = new Vector3(-1,-1,1);
        } else {
            SecondAmmendment.transform.localScale = new Vector3(-1,1,1);
        }
    }

    void ShootingLogic(){
        if (Input.GetMouseButtonDown(0)) // Left mouse button click
        {
            instance = Instantiate(Bullet, SecondAmmendment.transform.position, Quaternion.identity);
            /* 
            float xcomponent = Mathf.Cos(angle * Mathf.PI / 180) * bulletSpeed;
            float ycomponent = Mathf.Sin(angle * Mathf.PI / 180) * bulletSpeed;
            Vector3 asjfdn = new Vector3(ycomponent, 0, xcomponent);
            */

            Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
            
            instance.GetComponent<Rigidbody2D>().AddForce(dir * bulletSpeed);
            
            

            /*
            Debug.Log("amgonsu");
            RaycastHit2D ray = Physics2D.Raycast(transform.position, Player.transform.position - transform.position); 
            if (ray.collider != null)
            {
                // Raycast hit something!
                Debug.DrawRay(transform.position, SecondAmmendment.transform.position - transform.position, Color.red);
                Debug.Log("Hit");
                // Handle the hit (e.g., damage the object, play a sound, etc.)
            }
            else
            {
                // Raycast didn't hit anything
                Debug.DrawRay(transform.position, SecondAmmendment.transform.position - transform.position, Color.red);
                Debug.Log("No hit");
            }
            */
        }
            
    }
}
