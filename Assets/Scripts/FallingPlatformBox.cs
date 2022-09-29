using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallingPlatformBox : MonoBehaviour
{
    private float fallDelayBox = 0.4f;


    [SerializeField] private Rigidbody2D rb1;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            StartCoroutine(FallBox());
        }
    }

    private IEnumerator FallBox()
    {
        yield return new WaitForSeconds(fallDelayBox);
        rb1.bodyType = RigidbodyType2D.Dynamic;

    }

}
