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
