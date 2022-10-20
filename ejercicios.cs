// Son ejemplos concretos, no ejecutables, solo visuales


// Control de metodos 

    private void Awake()
    {
        EsDivisible();
    }

    private void EsDivisible()
    {
        Debug.Log($"Dividir  {numero2} entre {numero1}? + {SeDivide(numero2, numero1)}");
    
    }

    private bool SeDivide(int param1, int param2)
    {
        return param1 / param2 == 0;
    }
    
    
    

//////////////////////////////////////////////////////////////////////////



///////////////////////       SWITCH       ///////////////////////////////



//////////////////////////////////////////////////////////////////////////

private void Awake()
    {
        EjercicioSwitch();

    }

    private void EjercicioSwitch(){
        print($"El dia es {DiaSemana(numero1)}");

    }


    private string DiaSemana(int num)
    {
        string resultado = "";
        switch (num)
        {
        case 7:
            resultado = "Domingo";
            break;    
        case 6:
            resultado = "Sábado";
            break;
        case 5:
            resultado = "Viernes";
            break;
        case 4:
            resultado = "Jueves";
            break;
        case 3:
            resultado = "Miércoles";
            break;
        case 2:
            resultado = "Martes";
            break;
        case 1:
            resultado = "Lunes";
            break;
        default:
            resultado = "NUmero de dia no válido";
            break;
    }
    return resultado;



    }




//////////////////////////////////////////////////////////////////////////



///////////////////////       ENUM Y SWITCH       ////////////////////////



//////////////////////////////////////////////////////////////////////////



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public enum DiasSemana
{
    Lunes, 
    Martes, 
    Miercoles, 
    Jueves, 
    Viernes, 
    Sabado, 
    Domingo
}




public class Ejercicios : MonoBehaviour
{
    // [SerializeField] int numero1 = 1;
    
    [SerializeField] DiasSemana diaSemana;

    
    private void Awake()
    {
        Ejercicio18SwitchConEnum();
    }




    private void Ejercicio18SwitchConEnum()
    {
        switch(diaSemana){
        case DiasSemana.Lunes:
            Debug.Log("1");
            break;
        case DiasSemana.Martes:
            Debug.Log("2");
            break;
        
        }
    }
}



//////////////////////////////////////////////////////////////////////////



///////////////////////       FOR y SUMA       ////////////////////////



//////////////////////////////////////////////////////////////////////////







public class Ejercicios : MonoBehaviour
{
    // [SerializeField] int numero1 = 1;
    
    [SerializeField] int numero1 = 10;


    
    private void Awake()
    {
        Ejercicio20SumaPrevia(); // Dado un numero, mostrar la suma de los numeros que lo anteceden 
        // (sin incluir el propio numero) hasta el 0 de forma decreciente
    }




    private void Ejercicio20SumaPrevia()
    {
        int sumarNumeros = 0;
        for (int iter = numero1-1; iter >= 0 ; iter--)
        {
            sumarNumeros = sumarNumeros + iter;
        }
        print($"La suma es {sumarNumeros}");
    
    }
}









//////////////////////////////////////////////////////////////////////////



///////////////////////       METDODOS 'DE SOBRECARGAS      ////////////////



//////////////////////////////////////////////////////////////////////////







    private int resultado1;
    private float resultado2;
    private void Awake()
    {
        Prueba(1, 2);
        Prueba(1.7f);

    }


    public void Prueba(int numero1, int numero2)
    {   
        resultado1 = numero1 + numero2; 
        print(resultado1);
    }
    public void Prueba(float numero3)
    {
        resultado2 = numero3 + numero3; 
        print(resultado2);
    }
    
    
    
    

//////////////////////////////////////////////////////////////////////////



///////////////////////       Preincremento       ////////////////////////
                                   ++x;


//////////////////////////////////////////////////////////////////////////


    
    
    
    
        private int x;
    private float y;
    private void Awake()
    {
        x = 1;
        y = x++;
        Debug.Log($"{x}, {y}"); // Post-Incremento La salida es '2, 1'


        x = 1;
        y = ++x;
        Debug.Log($"{x}, {y}"); // Pre-Incremento La salida es '2, 1'
    }

















//////////////////////////////////////////////////////////////////////////



///////////////////////     Excepciones     ////////////////////////



//////////////////////////////////////////////////////////////////////////

using System;

    private void Awake()
    {
        if (1<2){
            throw new Exception("Excepción");
        }
    }
    
    
    
    
    
   //////////////////////////////////////////////////////////////////////////



///////////////////////     OBJETOS     ////////////////////////



//////////////////////////////////////////////////////////////////////////

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class Ejercicio42 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Rigidbody2D[] rigidBody2Ds;
    float currentTime = 0f;
    float startingTime = 0f;



    public float xspeed = 0.0f;
    public float yspeed = 0.0f;
    public float zspeed = 0.0f;


    public float xAngle, yAngle, zAngle;


    private GameObject objects;

    private void Start() {
        currentTime = startingTime;
    }


    private void Update() {
        // Ejecutar el void TestGet() cada segundo par
        currentTime += 1 * Time.deltaTime;
        //Debug.Log((int)currentTime);
        if ((int)currentTime%2==0)
        {
            DeActivateOdds();
            // objects.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);
            // En los segundos pares, desactivar los objetos impares
        }
        else
        {
            DeActivatePairs();
            // objects.transform.Rotate(xAngle, yAngle, zAngle, Space.Self);

            // En los segundos impares, desactivar los pares
        }
    }


    private void Awake()
    {


    }

    private void DeActivateOdds()
    {
        for (int index = 0; index < rigidBody2Ds.Length; index++)
        {
            if(index%2 == 0)
            {
                rigidBody2Ds[index].gameObject.SetActive(true);
            }
            else
            {
                rigidBody2Ds[index].gameObject.SetActive(false);
            }
        }
    }

    private void DeActivatePairs()
    {
        for (int index = 0; index < rigidBody2Ds.Length; index++)
        {
            if(index%2 != 0)
            {
                rigidBody2Ds[index].gameObject.SetActive(true);
            }
            else
            {
                rigidBody2Ds[index].gameObject.SetActive(false);
            }
        }
    }


}











    
   //////////////////////////////////////////////////////////////////////////



///////////////////////     ACTIVAR DESACTIVAS SPRITERENDERER     ////////////////////////



//////////////////////////////////////////////////////////////////////////





// activar/ desactivar sprite renderer


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio44 : MonoBehaviour
{
    [SerializeField] GameObject[] _gameObjects;



    private void Awake()
    {
        for ( int index = 0 ; index < _gameObjects.Length; index++ )
        {
            if (_gameObjects[index].GetComponent<SpriteRenderer>() != null)
            {
                _gameObjects[index].GetComponent<SpriteRenderer>().enabled = true;
            }
            else
            {
                _gameObjects[index].gameObject.SetActive(false);
                
            }
        }
    }
}


