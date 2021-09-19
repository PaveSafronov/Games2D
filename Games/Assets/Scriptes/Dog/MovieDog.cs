using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovieDog : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private float power;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>(); 

    }

    private void Update()
    {

        if (GetComponent<Rigidbody2D>().gravityScale != 0)
        { rb.velocity = new Vector2(-1 * power, rb.velocity.y); }
        else
        {
            rb.velocity = new Vector2(0 * power, rb.velocity.y);

        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 7)
        {
            GetComponent<Animator>().SetBool("Fight", true);
        }

    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        GetComponent<Animator>().SetBool("Fight", false);
    }

}
