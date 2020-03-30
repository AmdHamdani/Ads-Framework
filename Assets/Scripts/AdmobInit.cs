using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AdmobInit : MonoBehaviour
{

    public string appID;

    void Start()
    {
        MobileAds.Initialize(appID);
    }

}
