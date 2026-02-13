using UnityEngine;

public class HealthV1 : MonoBehaviour
{
    public int maxHealth = 100;
    //public int currentHealth;
    public void TakeDamage(int damage)
    {
        maxHealth -= damage;
        if (maxHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
