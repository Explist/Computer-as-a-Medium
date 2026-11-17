using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    // components
    public Animator animator;
    public GameObject bullet;
    public Transform firePoint;

    // values
    public bool rangedAttack = false;
    private bool rangedOnCooldown = false;
    public float rangedCooldown = 3f;

    // Update is called once per frame
    void Update()
    {
        // decide which attack to use
        if (rangedAttack)
            Shoot();
        else
            Attack();
    }

    void Attack()
    {
        // swing the sword if the correct key is pressed
        if (Keyboard.current.fKey.isPressed)
        {
            animator.SetBool("Swing", true);
        }
        else
        {
            animator.SetBool("Swing", false);
        }
    }

    void Shoot()
    {
        // fire a bullet if the correct key is pressed
        if (Keyboard.current.fKey.wasPressedThisFrame)
        {
            if (bullet != null && !rangedOnCooldown)
            {
                Instantiate(bullet, firePoint.position, firePoint.rotation);
                StartCoroutine(RangedCooldown());
            }
        }
    }

    IEnumerator RangedCooldown()
    {
        rangedOnCooldown = true;
        yield return new WaitForSeconds(rangedCooldown);
        rangedOnCooldown = false;
    }
}
