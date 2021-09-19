using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Knife : MonoBehaviour
{
    [SerializeField] private Text score;
    private int schet;
    public Schetchik schetchik;

    private void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.gameObject.layer == 9)
        {
            collision.GetComponent<Animator>().SetBool("Death", true);

            collision.GetComponent<CapsuleCollider2D>().enabled = false;
            collision.GetComponent<Rigidbody2D>().gravityScale = 0;
            schet = int.Parse(score.text)+100;
            score.text = schet.ToString();
            ++schetchik.schetMonster;

         

        }
    }

}
