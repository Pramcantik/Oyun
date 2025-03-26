using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int health = 3;

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }
}
