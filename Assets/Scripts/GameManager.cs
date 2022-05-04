using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
 public int coins;
 string Coin;
 Text coinCount;
 GameObject WinScreen;

 void Awake()
 {
   coinCount = GameObject.Find("CoinCount").GetComponent<Text>();
   WinScreen = GameObject.Find("Win");
 }

 void Start()
 {
  WinScreen.SetActive(false);
 }

 void Update()
 {
  Coin = coins.ToString();
  coinCount.text = "Coins: " + Coin + "/10";

  if(coins == 10)
  {
      Win();
  }


  if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
 }

 void Win()
 {
  Time.timeScale = 0f;    
  WinScreen.SetActive(true);
 }

 public void Lose()
 {
  SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  
 }
}
