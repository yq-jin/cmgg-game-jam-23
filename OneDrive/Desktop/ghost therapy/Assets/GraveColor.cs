using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraveColor : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer.color = Color.red;
    }

    void OnCollisionStay2D(Collision2D collision)
    {
        spriteRenderer.color = Color.white;

    }
}
