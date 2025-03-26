using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public AttributesManager playerAtm;

    public AttributesManager enemyAtm;
    
    public PlayerMovement stop;
    
    public LoS seeMe;
    // Start is called before the first frame update
    private float attackCooldown = 2f;
    private float elapsedTime = 0f;
    private float chargeTime = 1f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if (seeMe.distanceToAttached <= 5)
        {
            if (elapsedTime >= attackCooldown)
            {
                Debug.DrawLine(seeMe.transform.position, seeMe.attached.transform.position - seeMe.transform.position,
                    Color.yellow);
                if (Input.GetKey(KeyCode.Mouse1))
                {
                    Debug.Log(enemyAtm.health);
                    playerAtm.autoDamage(enemyAtm.gameObject);
                    elapsedTime = 0.0f;

                }

                if (Input.GetKey(KeyCode.Mouse2))
                {
                    Debug.Log(enemyAtm.health);
                    charge();
                    playerAtm.HeavyDamage(enemyAtm.gameObject);
                    elapsedTime = 0.0f;
                }
                else
                {
                    stopDefault();
                }
                
                if (Input.GetKey(KeyCode.Z))
                {
                    Time.timeScale = .05;
                }
                else
                {
                    Time.timeScale = 1;
                }
            }
        }
    }

    void stopDefault()
    {
        stop.speed = 10;
        stop.jumpingPower = 20;
    }
    void charge()
    {
        stop.speed = 0;
        stop.jumpingPower = 0;
    }
}
