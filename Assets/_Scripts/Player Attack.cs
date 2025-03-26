using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public AttributesManager playerAtm;

    public AttributesManager enemyAtm;

    public LoS seeMe;
    // Start is called before the first frame update
    private float attackCooldown = 2;
    private float elapsedTime = 0f;
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
                    playerAtm.DealDamage(enemyAtm.gameObject);
                    elapsedTime = 0.0f;

                }
            }
        }
    }
}
