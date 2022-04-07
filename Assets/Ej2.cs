using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ej2 : MonoBehaviour
{
    public int precio1, precio2, precio3, dinero;
    // Start is called before the first frame update
    void Start()
    {
        int VTotal = precio1 + precio2 + precio3;
        int Resto = dinero - VTotal;
        int Falta = VTotal - dinero;
        if (VTotal < dinero)
        {
            Debug.Log("La suma de dinero alcanza y sobra/n " + Resto + " peso/s");
        }

        else
        {
            Debug.Log("La suma de dinero no alcanza y falta/n " + Falta + " peso/s");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
