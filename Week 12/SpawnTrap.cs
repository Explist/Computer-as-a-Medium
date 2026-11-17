using UnityEngine;
using System.Collections;
using UnityEditor.Experimental.GraphView;

public class SpawnTrap : MonoBehaviour
{
    public GameObject FireBall;
    public bool checkIfOnFire = false;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && !checkIfOnFire)
        {
            FireBall.SetActive(true);
            StartCoroutine(FireOut());
        }
            
    
    }

    IEnumerator FireOut()
    {
        checkIfOnFire = true;
        yield return new WaitForSeconds(3f);
        checkIfOnFire = false;
        FireBall.SetActive(false);
    }

}
