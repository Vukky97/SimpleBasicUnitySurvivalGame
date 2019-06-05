using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLifeManagement : MonoBehaviour
{
    int NumberOfLives;
    bool InLive;
    bool InLight;

    void Start()
    {
        NumberOfLives = 100;
        InLive = true;
        //InLight;

    }
    public void SetInLight(bool bennvan)
    {
        InLight = bennvan;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        checkLive();
        if (InLight)
        {
            
        }
        else if (!InLight)
        {
            NumberOfLives -= (int)Time.time;
            //Debug.Log((int)Time.time);
        }
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
        NumberOfLives -= (int)Time.smoothDeltaTime *10;
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER!");
    }
}
