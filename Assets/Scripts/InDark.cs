using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InDark : MonoBehaviour
{
    public PlayerLifeManagement playerLifeManagement;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerOutOfLight();
            //Debug.Log("Player enter in the dark area!");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerOutOfLight();
            //Debug.Log("Player stay in dark area!");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            //Debug.Log("Exit dark area");
            playerLifeManagement.SetInLight(true);
        }
    }
    public void PlayerOutOfLight()
    {
        playerLifeManagement.SetInLight(false);
        //playerLifeManagement.DecreaseLiveAmount();
    }

}
