using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInLight : MonoBehaviour
{
    [SerializeField] PlayerLifeManagement playerLifeManagement = null;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerUnderLight();
            //Debug.Log("Player enter in the light area!");
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            PlayerUnderLight();
            //Debug.Log("Player stay in light area!");
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Eddig jo");
            PlayerOutOfLight();
            playerLifeManagement.SetInLight(false); 
        }
    }
    public void PlayerOutOfLight()
    {
        playerLifeManagement.SetInLight(false);
        //playerLifeManagement.DecreaseLiveAmount();
    }
    public void PlayerUnderLight()
    {
        playerLifeManagement.SetInLight(true);
    }

}
