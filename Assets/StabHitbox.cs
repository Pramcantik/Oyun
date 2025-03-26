using UnityEngine;

public class StabHitbox : MonoBehaviour
{
    public int damage = 1;
    public Animator animator;
    
private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Hitbox çarptı: " + other.name);

        if (other.CompareTag("Enemy"))
        {
            Debug.Log("Düşman algılandı!");
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
        //Attacking = false;
        stabHitbox.SetActive(false); // Bu �nemli k�s�m
        animator.Play("Idle"); // veya ba�ka bir animasyona ge�
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
