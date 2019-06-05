using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public GameObject FinishLaser;
    public SpriteRenderer spriteR;
    public DiscoLights discoLight;
    

    void Start()
    {
        spriteR.color = Color.red;
        StartCoroutine("ChangingFinishLineColours");
        //discoLight.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("Your Winner!");
            // TODO : ugyancsak game over, iranyitast letiltani
            // siman set false vel
            // animtor ugraljon
            discoLight.StartDisco();
            //discoLight.SetActive(true);
        }
    }


    //private void OnTriggerEnter(Collider objectToCollide)
    //{
       
    //}

    IEnumerator ChangingFinishLineColours()
    {
        while (true)
        {
            spriteR.color = Color.red;
            yield return (new WaitForSeconds(0.3f));
            spriteR.color = Color.grey;
            yield return (new WaitForSeconds(0.3f));
            spriteR.color = Color.red;
            yield return (new WaitForSeconds(0.3f));
            spriteR.color = Color.green;
            yield return (new WaitForSeconds(0.3f));
        }
    }

}
