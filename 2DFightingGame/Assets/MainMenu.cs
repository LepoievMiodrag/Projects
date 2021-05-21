using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class MainMenu : MonoBehaviour
{
    public GameObject button1;
    public GameObject button2;
    public GameObject text;
    public AIBullet control;
    public GameObject rope;

    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Resume()
    {
        rope.SetActive(true);
        Time.timeScale = 1f;
        button1.SetActive(false);
        button2.SetActive(false);
        text.SetActive(false);
    }

    public void Menu()
    {
        rope.SetActive(true);
        Time.timeScale = 1f;
        button1.SetActive(false);
        button2.SetActive(false);
        text.SetActive(false);
        Application.LoadLevel(0);
    }

    public void Menu2()
    {
        Application.LoadLevel(0);
    }

    public void Back()
    {
        Application.LoadLevel(0);
    }


    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void Restart()
    {
        Application.LoadLevel(2);
    }

    public void SetEasy()
    {
        control.damage = 15f;
        control.speed = 20f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetNormal()
    {
        control.damage = 40f;
        control.speed = 25f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetHard()
    {
        control.damage = 60f;
        control.speed = 35f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void SetXtreme()
    {
        control.damage = 99f;
        control.speed = 45f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
