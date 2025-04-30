using UnityEngine;

public class Killbox : MonoBehaviour
{
<<<<<<< HEAD
=======
    public int damage = 25;
>>>>>>> Finn
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Friend") && gameObject.name == "Kill Box")
        {
            AttributesManager attributesManager = other.GetComponent<AttributesManager>();
            if (attributesManager != null)
            {
                attributesManager.health = 0;
            }
            else
            {
                Debug.LogWarning("AttributesManager not found on player!");
            }
        } else if (other.CompareTag("Friend") && gameObject.name == "Freaky Spike")
        {
            AttributesManager attributesManager = other.GetComponent<AttributesManager>();
            if (attributesManager != null)
            {
<<<<<<< HEAD
                attributesManager.health -= 25;
=======
                attributesManager.health -= damage;
>>>>>>> Finn
            }
            else
            {
                Debug.LogWarning("AttributesManager not found on player!");
            }
        }
    }
}