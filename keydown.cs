// Script que añade al contador las pulsaciones de las flechas en parámetro de vertical y horizontal

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keydowns : MonoBehaviour
{
    private int vertical;
    private int horizontal;


    public Text verticalUI;
    public Text horizontalUI;

    public Text selectedCubeText;


    public GameObject CUBES; 



    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        teclasMovimientoSeleccion();
        GetCubes();

    }

    void teclasMovimientoSeleccion()
    {
        if (Input.GetKeyDown("up"))
            {
                vertical = vertical +1;
                verticalUI.text = vertical.ToString("");
                print(verticalUI);
            }
        else if (Input.GetKeyDown("down"))
            {
                vertical = vertical -1;
                verticalUI.text = vertical.ToString("");
                print(verticalUI);
            }


        if (Input.GetKeyDown("right"))
            {
                horizontal = horizontal +1;
                horizontalUI.text = horizontal.ToString("");
                print(verticalUI);
            }
        else if (Input.GetKeyDown("left"))
            {
                horizontal = horizontal -1;
                horizontalUI.text = horizontal.ToString("");
                print(horizontalUI);
            }
    }


    private void Awake()
    {
    }

    private void GetCubes()
    {
        Transform child = transform.GetChild(transform.childCount - 1);
        // Debug.Log("Child Count: " + transform.childCount);
        // Debug.Log(child.name);
    }



}
