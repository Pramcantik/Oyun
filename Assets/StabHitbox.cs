using UnityEngine;

public class StabHitbox : MonoBehaviour
{
    public int damage = 1;
    public Animator animator;
    
private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hitbox çarptý: " + other.name);

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Düþman algýlandý!");
            var enemy = other.GetComponent<EnemyHealth>();
            if (enemy != null)
            {
                enemy.TakeDamage(damage);
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
    void StopAttack()
    {
        Attacking = false;
        stabHitbox.SetActive(false); // Bu önemli kýsým
        animator.Play("Idle"); // veya baþka bir animasyona geç
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
