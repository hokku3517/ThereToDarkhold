using UnityEngine;

public class Killbox : MonoBehaviour
{
    public int damage = 25;
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Friend") && gameObject.name.Contains("Kill Box"))
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
        } else if (other.CompareTag("Friend") && gameObject.name.Contains("Freaky Spike"))
        {
            AttributesManager attributesManager = other.GetComponent<AttributesManager>();
            if (attributesManager != null)
            {
                attributesManager.health -= damage;
            }
            else
            {
                Debug.LogWarning("AttributesManager not found on player!");
            }
        } else if (other.CompareTag("Friend") && gameObject.name.Contains("Freaky Sphere"))
        {
            AttributesManager attributesManager = other.GetComponent<AttributesManager>();
            if (attributesManager != null)
            {
                attributesManager.health -= damage;
            }
            else
            {
                Debug.LogWarning("AttributesManager not found on player!");
            }
        }    
    }
}