using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    public Animator animator;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftClick))
        {
            Attack();
        }
    }

    void Attack()
    {
        // play a attack anim
        animator.SetTrigger("Attack");
        //detect enimes in rang
        
        // damage
    }
    }
}
