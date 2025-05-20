using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelMove_Ref : MonoBehaviour
{
    public int sceneBuldIndex;
    
    AttributesManager am;
    void Start(){
        am = new AttributesManager();

    }
    void Update(){
        Debug.Log(am.freakyBossDead);
        if (!am.freakyBossDead){
            gameObject.GetComponent<BoxCollider2D>().enabled = false;
        } else if (am.freakyBossDead){
            gameObject.GetComponent<BoxCollider2D>().enabled = true;
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        print("Trigger Entered");

        if (other.CompareTag("Friend")) 
        {
            print("Switching Scene to " + sceneBuldIndex);
            
            SceneManager.LoadScene(sceneBuldIndex, LoadSceneMode.Single);
        }
    }
}
