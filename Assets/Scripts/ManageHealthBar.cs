using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManageHealthBar : MonoBehaviour
{
    public PlayerLifeManagement PLM;
    public Image HealthBar;
    // Start is called before the first frame update
    void Start()
    {
        //HealthBar.fillAmount = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount= (PLM.GetLiveNumber() / 500f);
    }
}
