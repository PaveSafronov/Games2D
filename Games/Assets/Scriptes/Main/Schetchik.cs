using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Schetchik : MonoBehaviour
{
    public int schetMoneta = 0;
    public int schetMonster = 0;

    public Schetchik schetchik;

    [SerializeField] private GameObject button1;
    [SerializeField] private GameObject button2;
    [SerializeField] private Text scoreMonster;
    [SerializeField] private Text scoreMoneta;
    [SerializeField] private Text scoreMonster1;
    [SerializeField] private Text scoreMoneta1;

    private void OnTriggerEnter2D(Collider2D collision)
    {  scoreMonster.gameObject.SetActive(true);
        scoreMoneta.gameObject.SetActive(true);
        scoreMonster1.gameObject.SetActive(true);
        scoreMoneta1.gameObject.SetActive(true);
        button1.gameObject.SetActive(true);
        button2.gameObject.SetActive(true);

        scoreMonster.text = schetchik.schetMonster.ToString();
        scoreMoneta.text = schetchik.schetMoneta.ToString();
        
    }
 



}
