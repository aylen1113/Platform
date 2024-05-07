using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class VictoryZone : MonoBehaviour
{
    public GameObject victoryScreen;



    private void Start()
    {

        victoryScreen.SetActive(false);
    }

    private void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.CompareTag("Player"))

        {

            victoryScreen.SetActive(true);
            Debug.Log("You win!!!!!!");
        }

    }



    public void PlayGame()
    {
        SceneManager.LoadScene("Game");

    }
    public void Quit()
    {
        Application.Quit();

    }


}