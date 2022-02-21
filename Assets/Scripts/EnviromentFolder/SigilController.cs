using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigilController : Sigil
{

    public Sigil bondedSigil1;
    public Sigil bondedSigil2;

    public bool lastValue;
    public bool newValue;


    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (sigilActive == true)
        {
            Debug.Log("Circulo desactivado");
            sigilActive = false;
            mySpriteRenderer.material = unactiveMaterial;
            bondedSigils();
        }
        else
        {

            Debug.Log("Circulo activado");
            sigilActive = true;
            mySpriteRenderer.material = activeMaterial;
            bondedSigils();
      
        }

    }

    public void bondedSigils(){

        if (bondedSigil1.sigilActive == true)
        {
            bondedSigil1.sigilActive = false;
            bondedSigil1.mySpriteRenderer.material = unactiveMaterial;
        }
        else
        {
            bondedSigil1.sigilActive = true;
            bondedSigil1.mySpriteRenderer.material = activeMaterial;
        }

        if (bondedSigil2.sigilActive == true)
        {
            bondedSigil2.sigilActive = false;
            bondedSigil2.mySpriteRenderer.material = unactiveMaterial;

        }
        else
        {
            bondedSigil2.sigilActive = true;
            bondedSigil2.mySpriteRenderer.material = activeMaterial;
        }
    }

}
