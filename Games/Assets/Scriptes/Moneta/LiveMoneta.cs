using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LiveMoneta : MonoBehaviour
{
 public Text score;
    public Schetchik schetchik;
public AudioSource audioPlay;


   private int schet; 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.gameObject.layer == 7)
        {
            schet = int.Parse(score.text);
            schet += 100;

            score.text = schet.ToString();
            audioPlay.Play();
           ++schetchik.schetMoneta;
            Debug.Log(schetchik.schetMoneta);
            Destroy(gameObject);
          


        }



    }


}
