using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Random : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int num = UnityEngine.Random.Range(0, 21);
            Debug.Log(num);
            if (num == 5)
            {
                continue;
            }
            if (num == 15)
            {
                break;
            }
        }

    }
}