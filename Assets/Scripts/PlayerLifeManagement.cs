﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeManagement : MonoBehaviour
{
    float NumberOfLives;
    bool InLive;
    bool InLight;

    void Start()
    {
        NumberOfLives = 500f;
        InLive = true;
        InLight = true;
    }

    void FixedUpdate()
    {
        checkLive();
        if (InLight)
        {
            DontDecreaseLiveAmount();
        }
        else if (!InLight)
        {
            DecreaseLiveAmount();
        }
    }

    public void SetInLight(bool bennvan)
    {
        InLight = bennvan;
    }

    

    public bool checkLive()
    {
        if(NumberOfLives <= 0)
        {
            GameOver();
            return false;
        }
        return true;
    }

    public void DecreaseLiveAmount()
    {
        //Debug.Log("TenylegKiment");
        //NumberOfLives -= (float)Time.timeScale / 50;
        //Debug.Log("NumberOfLives:" + NumberOfLives + "Minus time" + (float)Time.time + "Equals to" + (NumberOfLives -= (float)Time.time));
        NumberOfLives--;
        //Debug.Log("NumberOfLives:" + NumberOfLives);

    }
    public void DontDecreaseLiveAmount()
    {
        //Debug.Log("TenylegKiment");
        Debug.Log("NumberOfLives:" + NumberOfLives);
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER!");
        // TODO: CANT MOVE CALL ANIMATOR
    }
}
