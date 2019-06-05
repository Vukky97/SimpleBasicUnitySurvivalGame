using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscoLights : MonoBehaviour
{
    public SpriteRenderer spriteR;
    

    void Start()
    {
        //StartCoroutine("ChangingDiscoColours");
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartDisco()
    {
        StartCoroutine("ChangingDiscoColours");
    }

    private void OnTriggerEnter(Collider objectToCollide)
    {
        if (objectToCollide.gameObject.name == "Player")
        {
            Debug.Log("Disco!");
            // animtor ugraljon,d e eleg a finisben is
        }
    }

    IEnumerator ChangingDiscoColours()
    {
        while (true)
        {
            spriteR.color = Color.blue;
            yield return (new WaitForSeconds(0.05f));
            spriteR.color = Color.cyan;
            yield return (new WaitForSeconds(0.05f));
            spriteR.color = Color.yellow;
            yield return (new WaitForSeconds(0.05f));
            spriteR.color = Color.red;
            yield return (new WaitForSeconds(0.05f));
            spriteR.color = Color.magenta;
            yield return (new WaitForSeconds(0.05f));
        }
    }
}
