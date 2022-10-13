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