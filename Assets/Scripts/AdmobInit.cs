using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdmobInit : MonoBehaviour
{

    public string appID;
    public Button initButton;

    void Awake()
    {

        MobileAds.Initialize(appID);

        AdmobAdBanner banner = GetComponent<AdmobAdBanner>();
        AdmobAdInterstitial interstitial = GetComponent<AdmobAdInterstitial>();
        AdmobAdRewarded rewarded = GetComponent<AdmobAdRewarded>();
        AdmobAdNative native = GetComponent<AdmobAdNative>();

        initButton.onClick.AddListener(() =>
        {
            Debug.Log("Init Ad Unit");
            banner.Init();
            interstitial.Init();
            rewarded.Init();
            native.Init();
        });
    }

}
