using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyMeAt0 : MonoBehaviour
{
    public AttributesManager hp;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hp.health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
