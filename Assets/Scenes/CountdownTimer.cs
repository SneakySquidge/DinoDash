using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CountdownTimer : MonoBehaviour
{
    public LogicScript Logic;
    float currentTime = 0f;
    float startingTime = 12f;

    [SerializeField] Text countdownText;

    void Start()
    {
        currentTime = startingTime;
    }
    
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString("0");

        if(currentTime <= 0)
        {
            currentTime = 0;
            Logic.WinScreen(); 
        }

        
    }
}
