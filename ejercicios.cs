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
    
    
    

