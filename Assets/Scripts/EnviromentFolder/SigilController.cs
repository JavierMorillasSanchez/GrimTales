using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SigilController : Sigil
{

    public Sigil bondedSigil1;
    public Sigil bondedSigil2;

    private AudioSource activateSigil;
    private AudioSource deActivateSigil;

    private void Awake()
    {

        activateSigil = GetComponent<AudioSource>();
        deActivateSigil = GetComponent<AudioSource>();

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (sigilActive == true)
        {
            sigilActive = false;
            deActivateSigil.Play();
            mySpriteRenderer.material = unactiveMaterial;
            bondedSigils();
        }
        else
        {

            sigilActive = true;
            activateSigil.Play();
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
