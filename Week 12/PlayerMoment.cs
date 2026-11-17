using UnityEngine;
using UnityEngine.InputSystem;

/// <summary>
/// Controls the movement of the player.
/// </summary>
public class PlayerMovement : MonoBehaviour
{
    // components
    public Rigidbody2D rb;
    public SpriteRenderer spriteRenderer;
    public Sprite jagTop;
    public Sprite jagDown;
    public Sprite jagLeft;
    public Sprite jagRight;

    public GameObject weaponCamel;

    // values
    [Min(0f)] public float moveSpeed = 5f;
    private float speedX = 0f;
    private float speedY = 0f;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    /// <summary>
    /// Controls horizontal, vertical movement
    /// </summary>
    void Movement()
    {
        // horizontal
        if (Keyboard.current.aKey.isPressed)
        {
            speedX = -moveSpeed;
            spriteRenderer.sprite = jagLeft;
            weaponCamel.transform.localScale = new Vector3(-0.3f, 0.3f, 0.3f);
        } 
        else if (Keyboard.current.dKey.isPressed)
        {
            speedX = moveSpeed;
            spriteRenderer.sprite = jagRight;
            weaponCamel.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
        }
        else
        {
            speedX = 0f;
        }

        // vertical
        if (Keyboard.current.wKey.isPressed)
        {
            speedY = moveSpeed;
            spriteRenderer.sprite = jagTop;
        } 
        else if (Keyboard.current.sKey.isPressed)
        {
            speedY = -moveSpeed;
            spriteRenderer.sprite = jagDown;
        } 
        else
        {
            speedY = 0f;
        }

        rb.linearVelocity = new Vector2(speedX, speedY);
    }
}
