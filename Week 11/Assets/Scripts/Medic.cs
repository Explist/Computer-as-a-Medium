using UnityEngine;

public class Medic : MonoBehaviour
{
    public PlayerHealth playerHealth;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (playerHealth.health <= 90)
                playerHealth.health += 10;
            else if (playerHealth.health < 100 && playerHealth.health > 90)
                playerHealth.health = 100;
            else
                return;
        }
        Destroy(gameObject);
    }
