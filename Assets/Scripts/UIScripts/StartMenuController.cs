using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{

    private AudioSource Accept;
    private AudioSource Negate;

    private void Awake()
    {
        Accept = GetComponent<AudioSource>(); 
        Negate = GetComponent<AudioSource>();
    }

    public void StartHauntedManor()
    {
        Accept.Play();
        SceneManager.LoadScene("Manor");

    }

    public void QuitGame()
    {
        Negate.Play();
        Application.Quit();

    }

    public void playToMenu()
    {
        Negate.Play();
        SceneManager.LoadScene("StartGame");

    }



}
