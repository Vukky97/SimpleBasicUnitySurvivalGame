using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLifeManagement : MonoBehaviour
{
    private static float NumberOfLives;
    bool InLive;
    bool InLight;

    public float GetLiveNumber()
    {
        return NumberOfLives;
    }

    //public void SetLiveNumber(float num)
    //{
    //    NumberOfLives = num;
    //}

    public void MinusLife(int num)
    {
        NumberOfLives -= num;
    }

    void Start()
    {
        NumberOfLives = 200f;
        InLive = true;
        InLight = true;
        StartCoroutine("checkPlayerIsLive");
        StartCoroutine("ChangeAmountOfLives");
    }

    void FixedUpdate()
    {      
        //checkLive();
        //Debug.Log(NumberOfLives);
        //if (InLight)
        //{
        //    DontDecreaseLiveAmount();
        //}
        //else if (!InLight)
        //{
        //    DecreaseLiveAmount();
        //}
    }

    public void SetInLight(bool bennvan)
    {
        InLight = bennvan;
    }

    

    //public bool checkLive()
    //{
    //    if(NumberOfLives <= 0)
    //    {
    //        GameOver();
    //        return false;
    //    }
    //    return true;
    //}

    public void DecreaseLiveAmount(int num)
    {
        //Debug.Log("TenylegKiment");
        //NumberOfLives -= (float)Time.timeScale / 50;
        //Debug.Log("NumberOfLives:" + NumberOfLives + "Minus time" + (float)Time.time + "Equals to" + (NumberOfLives -= (float)Time.time));
        NumberOfLives -= num;
        //Debug.Log("NumberOfLives:" + NumberOfLives);

    }

    public void DontDecreaseLiveAmount()
    {
        //NumberOfLives++;
        //Debug.Log("NumberOfLives:" + NumberOfLives);
    }

    IEnumerator checkPlayerIsLive()
    {
        while (true)
        {

            if (NumberOfLives <= 0)
            {
                GameOver();
            }
            yield return (new WaitForSeconds(0.20f));
        }
    }

    IEnumerator ChangeAmountOfLives()
    {
        while (true)
        {
            Debug.Log(NumberOfLives);
            if (InLight)
            {
                DontDecreaseLiveAmount();
            }
            else if (!InLight)
            {
                DecreaseLiveAmount(1);
            }
            yield return (new WaitForSeconds(0.20f));
        }
    }

    public void GameOver()
    {
        Debug.Log("GAME OVER!");

    }

  
}
