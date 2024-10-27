using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Array : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string[] words = { "Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird" };
        Random random = new Random();
        string sentence = "";
        int count = 0;
        while (count < 7)
        {
            int index = UnityEngine.Random.Range(0, words.Length);
            sentence += words[index] + " ";
            count++;
        }

        Debug.Log("Funny Sentence: " + sentence);


    }


}
