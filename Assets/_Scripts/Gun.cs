using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Gun : MonoBehaviour
{
    

    [SerializeField] private GameObject SecondAmmendment;
    [SerializeField] private GameObject Player;

    [SerializeField] private float mouseX;
    [SerializeField] private float mouseY;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        

        Vector3 mousePos = Input.mousePosition;
		mousePos.z = 5.23f;

		Vector3 objectPos = Camera.main.WorldToScreenPoint (transform.position);
		mousePos.x = mousePos.x - objectPos.x;
		mousePos.y = mousePos.y - objectPos.y;

		float angle = Mathf.Atan2(mousePos.y, mousePos.x) * Mathf.Rad2Deg;
        
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle));


        transform.position = new Vector3(Player.transform.position.x, Player.transform.position.y, 0);
        
        if (angle >= 90 || angle <= -90){
            SecondAmmendment.transform.localScale = new Vector3(-1,-1,1);
        } else {
            SecondAmmendment.transform.localScale = new Vector3(-1,1,1);
        }
    }
}
