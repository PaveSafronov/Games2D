using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
   [SerializeField] private int i;

    private void OnTriggerEnter2D(Collider2D collision)
    {
SceneManager.LoadScene(i);

    }
}
