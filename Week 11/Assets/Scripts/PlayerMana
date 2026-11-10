using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMana : MonoBehaviour
{
    //components
    public TMP_Text manaText;
    public Animator animator;

    // values
    [SerializeField][Min(0)] private int mana = 100;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DisplayMana();
    }

    // Update is called once per frame
    void Update()
    {
        UseMana();
        DisplayMana();
    }

    // detects the player's input to use mana
    void UseMana()
    {
        // 'r' pressed and mana above 0
        if (Keyboard.current.rKey.wasPressedThisFrame && mana > 0)
        {
            Magic();
        }
    }

    // reduce mana and do magical effect
    void Magic()
    {
        mana -= 10;
        animator.SetTrigger("ManaUsed");
    }

    // show the current mana on the screen
    void DisplayMana()
    {
        manaText.text = "Mana: " + mana;
    }
}
