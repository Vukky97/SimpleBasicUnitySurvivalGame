using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BadLighting : MonoBehaviour
{

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

    public float LighFrequency;

    void Start()
    {
        LighFrequency = Random.Range(0.7f, 1.3f);

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
            //BadLampy.SetActive(true);
        }
        else if(!isLight)
        {
            spriteRenderer.enabled = false;
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
            yield return (new WaitForSeconds(LighFrequency));

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



}
