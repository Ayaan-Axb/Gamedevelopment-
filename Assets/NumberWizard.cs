using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberWizard : MonoBehaviour
{
    int max = 1000;
    int min = 1;
    int guess = 500;
    // Start is called before the first frame update
    // Void is a method like a recipe starter
    // Works when game runs once and cannot be accessed later
    void Start()
    {
 
        Debug.Log("Welcome to number wizard, yo yeet");
        Debug.Log("Pick a number, don't tell me what it is...");
        Debug.Log("The highest number you can pick is 1000");
        Debug.Log("The lowest number you can pick is 1");
        Debug.Log("The highest number you can pick is: " + max);
        Debug.Log("The lowest number you can pick is: " + min);
        Debug.Log("Tell me if your number is higher or lower than 500");
        Debug.Log("Push Up = higher, Push Down = Lower, Push Enter = Correct");
    }

    // Update is called once per frame
    // Curly brackets mean more than 1 statment can be executed and VS will not be confused
    // After every frame this script runs.
    // Anything needed for instant reaction like up arrow and multiple unlike start which is once.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log("Up Arrow key was pressed.");
            min = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            Debug.Log("Down Arrow key was pressed.");
            max = guess;
            Debug.Log(guess);
        }
        else if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("Enter key was  not /pressed."); 
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Space key was pressed.");
        }
    }
}
