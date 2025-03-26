using UnityEngine;

public class StabHitbox : MonoBehaviour
{
    public int damage = 1;
    public Animator animator;
    
private void OnTriggerEnter2D(Collider2D other)
    {
        

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Hitbox çarptý: " + other.name);
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
            StopAttack();
        }
    }
    void Attack()
    {

        animator.SetBool("Attack",true);
        animator.Play("attack1-R");
        
    }
    void StopAttack()
    {
        animator.SetBool("Attack", false);
        stabHitbox.SetActive(false); // Bu önemli kýsým
        animator.Play("Movement-R"); // veya baþka bir animasyona geç
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
