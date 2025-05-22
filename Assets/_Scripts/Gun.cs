using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{
    
    
    [SerializeField] private GameObject SecondAmmendment;
    [SerializeField] private GameObject Player;

    [SerializeField] private GameObject Bullet;
    [SerializeField] private Rigidbody2D BulletRigidbody;

    [SerializeField] private GameObject Barrel;

    [SerializeField] private AudioSource audio;

    private float fireRate;

    private float mouseX;
    private float mouseY;

    private int bulletSpeed;

    bool canShoot;
    float angle;

    GameObject instance;

    
    // Start is called before the first frame update
    void Start()
    {
        BulletRigidbody = Bullet.GetComponent<Rigidbody2D>();
        canShoot = true;
        bulletSpeed = 1000;
        fireRate = .2f;
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
        if (Input.GetMouseButton(0) && canShoot == true) // Left mouse button click
        {
            StartCoroutine(Shooting());
        }
            
    }
    IEnumerator Shooting(){
            audio.Play(0);
            instance = Instantiate(Bullet, Barrel.transform.position, Quaternion.identity);
            Vector3 dir = Quaternion.AngleAxis(angle, Vector3.forward) * Vector3.right;
            instance.GetComponent<Rigidbody2D>().AddForce(dir * bulletSpeed);
            canShoot = false;
            yield return new WaitForSeconds(fireRate);
            canShoot = true;
            
             
    }
    
}
