using UnityEngine;
using System.Collections;
public class EnemyHealth : MonoBehaviour
{
    public Animator animator;
    public int health = 3;
    public int hasar= 50;
    public void TakeDamage(int amount)
    {
        if (animator.GetBool("IsTakingDamage")) return;

        health -= amount;
        if (health <= 0)
        {
            Die();
        }
        else {

            StartCoroutine(PlayDamageAnimation());
        }
    }

     private IEnumerator PlayDamageAnimation()
    {
        animator.SetBool("IsTakingDamage" ,true);
        
        yield return new WaitForSeconds(animator.GetCurrentAnimatorStateInfo(0).length); 
        // Animasyon süresi kadar bekle

        animator.SetBool("IsTakingDamage" ,false); // Animasyon bitince tekrar aç
    }

    public void Die()
    {
        animator.Play("Death");
        Destroy(gameObject);
    }
}
