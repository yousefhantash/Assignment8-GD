using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcerciseOne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        while (true)
        {
            int number = Random.Range(1, 21);
            if (number == 5)
            {
                continue;
            }
            if (number == 15)
            {
                break;
            }
            Debug.Log(number);
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
