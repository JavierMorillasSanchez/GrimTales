using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sigil : MonoBehaviour
{

    public bool sigilActive;

    public Sigil alwaysFalse;

    public SpriteRenderer mySpriteRenderer;

    public Material activeMaterial;
    public Material unactiveMaterial;

    private void Awake()
    {
        if (Random.value >= 0.5)
        {
            sigilActive = true;
            mySpriteRenderer.material = activeMaterial;

        }
        else
        {

            sigilActive = false;
            mySpriteRenderer.material = unactiveMaterial;

        }

        if (alwaysFalse != null)
        {
            sigilActive = false;
        } 
        return;
        

    }

    private void Update()
    {

        if (sigilActive == true)
        {
            mySpriteRenderer.material = activeMaterial;
        }
        else
        {
            mySpriteRenderer.material = unactiveMaterial;
        }
    }

    public void Order()
    {

        if (sigilActive == true)
        {

            sigilActive = false;
            mySpriteRenderer.material = unactiveMaterial;
            
        }
        else
        {

            sigilActive = true;
            mySpriteRenderer.material = activeMaterial;
           
        }

    }

}
