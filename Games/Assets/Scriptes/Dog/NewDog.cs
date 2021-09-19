using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class NewDog : MonoBehaviour
{
    public GameObject Boss;
    private float timer = 5;


    private void Update()
    {

        timer -= Time.deltaTime;


        if (timer <= 0)
        {
            GameObject newBullet = Instantiate(Boss, transform.position, Quaternion.identity);
            timer = 10;
        }
    
    }



 
}
