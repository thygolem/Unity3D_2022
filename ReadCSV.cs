// Script que lee archivo csv en el proyecto de unity

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ReadCSV : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        ReadCSVFile();
    }

    // Update is called once per frame
    void ReadCSVFile()
    {
        StreamReader strReader = new StreamReader("C:\\Users\\USUARIO\\Desktop\\ivan\\pruebas2D 05 09\\Assets\\Resources\\pruebaCSV.csv");
        bool endOfFile = false;
        while(!endOfFile)
        {
            string data_string = strReader.ReadLine();
            if (data_string == null)
            {
                endOfFile = true;
                break;
            }
            var data_values = data_string.Split(',');
            // for (int i = 0; i < data_values.Length; i ++){
            //     Debug.Log($"Value{i.ToString()} {data_values[0].ToString()}");
            // }
            // Debug.Log ( data_values[0].ToString()+ " "+
            //             data_values[1].ToString()+ " "+
            //             data_values[2].ToString()+ " "+
            //             data_values[3].ToString()
            //             );
        }
    
    
    }
}
