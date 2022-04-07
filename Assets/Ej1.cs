using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej1 : MonoBehaviour
{
    public int num1, num2;
    // Start is called before the first frame update
    void Start()
    {
        if (num1 == num2)
        {
            Debug.Log("Los números " + num1 + " y " + num2 + " son iguales");
        }

        else
        {
            Debug.Log("Los números " + num1 + " y " + num2 + " no son iguales");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
