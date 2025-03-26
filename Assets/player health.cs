using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] 
    private int _maxhp = 100;
    private int _hp;

    public int hp
    {
        get => _hp;
        private set
        {
            bool isDamage = value < _hp;
            _hp = Mathf.Clamp(value, 0, _maxhp);
        }
    }

    private void Start()
    {
        _hp = _maxhp;
    }

    public void Die()
    {
        Destroy(gameObject);
    }

    public void Hasaral(int amount)
    {
        hp -= amount;
        if (hp <= 0)
        {
            Die();
        }
    }

    public void Heal(int amount)
    {
        hp += amount;
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
            EnemyHealth EnemyHealth = other.gameObject.GetComponent<EnemyHealth>();
            if (EnemyHealth != null){

                int hasar = EnemyHealth.hasar; // Hasar değerini çek
                Hasaral(hasar);
                Debug.Log(other.gameObject.name + " vurdu! Hasar: " + hasar);

            }
        }
    }
}
