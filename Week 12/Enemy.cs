using UnityEngine;

[RequireComponent(typeof(CircleCollider2D))]
public class Enemy : MonoBehaviour
{
    public int enemyHealth = 50;

    // Update is called once per frame
    void Update()
    {
        Death();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Sword"))
        {
            enemyHealth -= 10;
        }
        else if (collision.CompareTag("Bullet"))
        {
            Destroy(collision.gameObject);
            enemyHealth -= 25;
        }
    }

    void Death()
    {
        if (enemyHealth <= 0)
        {
            Destroy(gameObject);
        }
    }
}
