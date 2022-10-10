using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectObject : MonoBehaviour
{
    // Start is called before the first frame update

    private Renderer Cube;

    public Material MainMaterial;
    Color color; // Chachea el color original del objeto


    void Start()
    {
        Cube = GetComponent<Renderer>();
        
    }

    // Update is called once per frame
    void Update()
    {

        
    }

    private void OnMouseEnter()
    {
        color = Cube.material.color;
        Cube.material.color = Color.red;
    }
    private void OnMouseExit()
    {
        Cube.material.color = color;
        // Cube.material = MainMaterial;
    }
    
}
