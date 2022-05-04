using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spike : MonoBehaviour
{
    GameManager gameManager;
void Awake()
{
 gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
}

void OnTriggerEnter2D(Collider2D col)
 {
     if(col.gameObject.CompareTag("Player"))
     {
      gameManager.Lose();
     }
 }
}
