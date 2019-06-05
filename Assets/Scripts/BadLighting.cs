using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadLighting : MonoBehaviour
{

    public PlayerLifeManagement playerLifeManagement;

    private List<bool> LightListVariantFirst = new List<bool>(){ false, true, false, true, false };
    private List<bool> LightListVariantSecond = new List<bool>() { false, false, false, true, true };
    private List<bool> LightListVariantThird = new List<bool>() { false, false, true, false, true };
    private List<bool> LightListVariantFourth = new List<bool>() { true, true, true, false, false };
    private List<bool> LightListVariantFift= new List<bool>() { false, true, false, false, true };

    //private List<List<bool>> LightLists = new List<List<bool>>() {
    // new List<bool>(){ false, true, false, true, false },
    // new List<bool>() { false, false, false, true, true },
    // new List<bool>() { false, false, true, false, true },
    // new List<bool>() { true, true, true, false, false },
    // new List<bool>() { false, true, false, false, true } };

    private List<bool> SelectedList = new List<bool>();

    private bool IsLight;
    //public GameObject BadLampy;
    public SpriteRenderer spriteRenderer;

    private float LightFrequency;
    //Collider2D col;

    bool SpriteRendererEnabled = true;

    void Start()
    {
        // Random  Time Stamps for higher variance
        LightFrequency = Random.Range(0.7f, 1.3f);

        int SelectLightListOnRandom = Random.Range(0, 4);
        switch(SelectLightListOnRandom){
            case 0:
                SelectedList = LightListVariantFirst;
                break;
            case 1:
                SelectedList = LightListVariantSecond;
                break;
            case 2:
                SelectedList = LightListVariantThird;
                break;
            case 3:
                SelectedList = LightListVariantFourth;
                break;
            case 4:
                SelectedList = LightListVariantFift;
                break;
            default:
                Debug.Log("Hiba az elágazásban (BadLighting.cs)");
                break;

        }
        

        
        //StartCoroutine(Interrupt());
        //Fv();
        StartCoroutine("HideUnhide");
    }

    void Update()
    {
        // Túlsálgosan költséges, processzor terhelő és a Sleepet sem kezeli jól. -> COroutine helyette
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            if (SpriteRendererEnabled)
            {
                Debug.Log("Workin");
                PlayerUnderLight();
            }
            if (!SpriteRendererEnabled)
            {
                Debug.Log("Workin too");
                PlayerOutOfLight();
            }



            //if (spriteRenderer.enabled)
            //    PlayerUnderLight();
            //else
            //    PlayerOutOfLight();
            //Debug.Log("OnTriggerEnterWorking");
        }
    }

    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if (collision.gameObject.name == "Player")
    //    {

    //    }
    //}

    //What you is what you get
    // ( if the sprite is visible then its doesnt decreaease the amount of life.)
    //public void WYSIWYG()
    //{
    //    if (spriteRenderer.enabled)
    //    {
    //        OnTriggerEnter2D(col);


    //    }
    //}


    private void OnTriggerStay2D(Collider2D collision)
    {

        if (SpriteRendererEnabled)
        {
            Debug.Log("Working 3");
            //PlayerUnderLight();
        }
        if (!SpriteRendererEnabled)
        {
            Debug.Log("Working 4");
            // PlayerOutOfLight();
        }



        //if (collision.gameObject.name == "Player")
        //{
        //    if(spriteRenderer.enabled)
        //        PlayerUnderLight();
        //    else
        //        PlayerOutOfLight();
        //    //Debug.Log("OnTriggerStay Working");
        //}
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (SpriteRendererEnabled)
        {
            PlayerUnderLight();
        }
        if (!SpriteRendererEnabled)
        {
            //PlayerOutOfLight();
        }

        //if (collision.gameObject.name == "Player")
        //{
        //    if(spriteRenderer.enabled)
        //    PlayerOutOfLight();
        //    //Debug.Log("OnTriggerExit Working");
        //    PlayerOutOfLight();
        //    //playerLifeManagement.SetInLight(false);
        //}
    }

    //IEnumerator Interrupt()
    //{
    //    for (int i = 0; i< 50; i++)
    //    {
    //        if (i == 4)
    //        {
    //            i = 0;
    //        }
    //        IsLight = LightList[i];
    //        SetCompoent(IsLight);
    //        new WaitForSeconds(1);
    //        //yield return 0;
    //    }

    //    yield return new WaitForSeconds(1);
    //}

    public void SetCompoent(bool isLight)
    {
        if (isLight)
        {
            //TODO: meghivni egy fv t ami megalatja az eleteropontok elveszetset, v collidert bekapcsolni
            spriteRenderer.enabled = true;
            SpriteRendererEnabled = true;
            //BadLampy.SetActive(true);
        }
        else if(!isLight)
        {
            spriteRenderer.enabled = false;
            SpriteRendererEnabled = false;
        }
    }

    IEnumerator HideUnhide()
    {
        int i = 0;
        while (true)
        {         
            IsLight = SelectedList[i];
            SetCompoent(IsLight);
            i++;
            yield return (new WaitForSeconds(LightFrequency));

            //yield return (new WaitForSeconds(1));
            //spriteRenderer.enabled = true;
            //yield return (new WaitForSeconds(1));
            //spriteRenderer.enabled = false;
            if (i == 4)
            {
                i = 0;
            }
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
