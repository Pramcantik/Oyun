using UnityEngine;

public class EnemyHealth : MonoBehaviour
{
    public int health = 3;
    public int hasar= 50;

    public void TakeDamage(int amount)
    {
        health -= amount;
        if (health <= 0)
        {
            Die();
        }
    }

    public void Die()
    {
        Destroy(gameObject);
    }
}
