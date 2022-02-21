using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class ManorGrid : MonoBehaviour
{
    private GridScript<bool> grid;


    // Start is called before the first frame update
    private void Start()
    {
        grid = new GridScript<bool>(19, 14, 0.70f, new Vector3(-4.4f, -7.2f));
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), true);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }

}
