using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenuController : MonoBehaviour
{
    
    public void StartHauntedManor()
    {

        SceneManager.LoadScene("Manor");

    }

    public void QuitGame()
    {

        Application.Quit();

    }



}
