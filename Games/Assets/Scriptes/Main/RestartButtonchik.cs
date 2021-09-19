using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RestartButtonchik : MonoBehaviour
{
    public PlayerMovie playerMovie;
    public GameObject knight;
    public GameObject button2;

    private float timer;
    public void onClick2 ()
    { 
        knight.transform.position = new Vector3(-32.7f, -30.02f, 0);


        playerMovie.trup = false;

      
        playerMovie.anime.SetBool("DeathKnight", false);
        playerMovie.anime.SetBool("DeathStay", true);


        playerMovie.GetComponent<Rigidbody2D>().gravityScale = 6;
        playerMovie.Head.gameObject.SetActive(true);
        playerMovie.Korpus.gameObject.SetActive(true);

        button2.gameObject.SetActive(false);






    }






}
