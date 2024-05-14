using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.InputSystem;

public class GameOverManager : MonoBehaviour

{
    public GameObject BadEnding;
    public GameObject GoodEnding;
    private Health health;
    public Timer timer;
    public GameObject ESpner;
    public GameObject Gleave;
    public GameObject Bleave;
    // Start is called before the first frame update
    void Start()
    {
        health = GetComponent<Health>();
    }

    // Update is called once per frame
    void Update()
    {
        Bad();
        Good();
    }
    public void Bad()
    {
        if (health.health <= 0)
        {
            BadEnding.SetActive(true);
            timer.time = "999:999";
            ESpner.SetActive(false);
            EventSystem.current.SetSelectedGameObject(Bleave);
        }
    }
    public void Good()
    {
        if (timer.time == "0:00")
        {
            GoodEnding.SetActive(true);
            health.health = 999;
            ESpner.SetActive(false);
            EventSystem. current.SetSelectedGameObject(Gleave);
        }
    }
    public void SetTimer()
    {
        timer.minutes = 0;
        timer.seconds = 1;
    }

    
}
