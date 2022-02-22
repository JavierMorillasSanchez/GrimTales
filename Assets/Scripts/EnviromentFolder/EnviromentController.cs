using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnviromentController : MonoBehaviour
{

    public Sigil Sigil1;
    public Sigil Sigil2;
    public Sigil Sigil3;
    public Sigil Sigil4;
    public Sigil Sigil5;

    public void YouWon(){

        SceneManager.LoadScene("youWonScene");

    }

    private void Update()
    {
        
        if (Sigil1.sigilActive == true && Sigil2.sigilActive == true && Sigil3.sigilActive == true && Sigil4.sigilActive == true && Sigil5.sigilActive == true)
        {

            Invoke("YouWon",1);

        }

    }





}
