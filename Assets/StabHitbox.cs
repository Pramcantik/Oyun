using UnityEngine;

public class StabHitbox : MonoBehaviour
{
    public int damage = 1;
    public Animator animator;
    
private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Debug.Log("We hit");
            var enemy = other.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
                Debug.Log("We hit");
            }
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Attack();
        }
    }
    void Attack()
    {

        animator.SetTrigger("Attack");
    }
    public GameObject stabHitbox;

    public void EnableHitbox()
    {
        stabHitbox.SetActive(true);
    }

    public void DisableHitbox()
    {
        stabHitbox.SetActive(false);
    }
}
