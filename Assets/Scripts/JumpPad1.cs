using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPad1 : MonoBehaviour
{
    [SerializeField] private float bounce = 27f;

    private void OnCollisionEnter2D(Collision2D collision)
    {
       
        if (collision.gameObject.CompareTag("Player2"))
        {
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * bounce, ForceMode2D.Impulse);
        }
    }
}
