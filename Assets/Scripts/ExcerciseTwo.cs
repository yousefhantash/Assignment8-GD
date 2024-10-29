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


        while (true)
        {
            int index = Random.Range(0, words.Length);
            sentence += words[index] + " ";

        }
        Debug.Log("Funny Sentence: " + sentence);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
