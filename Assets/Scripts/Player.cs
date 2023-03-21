using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float jumpForce = 5;
    [SerializeField] Rigidbody2D rb;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        //RaycastHit2D hit = Physics2D.Raycast(transform.position,)
    }
}
