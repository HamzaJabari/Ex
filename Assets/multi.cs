using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class multi : MonoBehaviour
{
    int Multiply(int a, int b)
    {

        return a * b;
    }
    // Start is called before the first frame update
    void Start()
    {
        int num = 5;
        Debug.Log("Multiplication table for  5 is : ");
        for (int i = 1; i <= 10; i++)
        {

            int result = Multiply(num, i);
            Debug.Log(i + " * 5 = " + result);
        }



    }

    // Update is called once per frame

}
