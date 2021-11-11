using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterDatabase characterDB;

   // public Text nameText;
    public SpriteRenderer artworkSprite;

    private int selectedOption = 0;

    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    // Start is called before the first frame update
    void Start()
    {
        if (!PlayerPrefs.HasKey("selectedOption"))
        {
            selectedOption = 0;
        }
        else
        {
            Load();
        }

        UpdateCharacter(selectedOption);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float directionY = Input.GetAxisRaw("Vertical");
        playerDirection = new Vector2(0, directionY).normalized;
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
    private void UpdateCharacter(int selectedOption)
    {
        Character character = characterDB.GetCharacter(selectedOption);
        artworkSprite.sprite = character.characterSprite;
       
    }
    private void Load()
    {
        selectedOption = PlayerPrefs.GetInt("selectedOption");
    }
}
