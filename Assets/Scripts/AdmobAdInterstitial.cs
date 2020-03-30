using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdmobAdInterstitial : MonoBehaviour
{

    public string adUnitId;

    private InterstitialAd interstitial;
    private Button showButton;

    private void Start()
    {
        RequestInterstitial();

        showButton = GameObject.Find("Show Interstitial").GetComponent<Button>();

        showButton.onClick.AddListener(() => { if (interstitial.IsLoaded()) interstitial.Show(); });
    }

    private void RequestInterstitial()
    {
        // Initialize an InterstitialAd.
        interstitial = new InterstitialAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the interstitial with the request.
        interstitial.LoadAd(request);
    }
}
