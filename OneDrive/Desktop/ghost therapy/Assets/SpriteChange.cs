using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChange : MonoBehaviour
{
    public GameObject player;
    [SerializeField]
    public SpriteRenderer spriteRenderer;
    [SerializeField]
    public Sprite newSprite;
    private CollisionCheck colCheck;

    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.name == "player" && player.GetComponent<CollisionCheck>().openGate == true)
        { 
            spriteRenderer.sprite = newSprite;
        }
    }
}
