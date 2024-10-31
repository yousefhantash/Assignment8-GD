using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExcerciseTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        string sentence = "";
        int wordCounter = 0;


        while (wordCounter < 7)
        {
            int index = Random.Range(0, 10);
            sentence += words[index] + " ";
            wordCounter++;

        }
        Debug.Log(sentence);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
