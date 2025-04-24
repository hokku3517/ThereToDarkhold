using UnityEngine;

public class Killbox : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Friend"))
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
        }
    }
}