//using GoogleMobileAds.Api;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class AdmobAdInterstitial : MonoBehaviour
//{

//    public string adUnitId;

//    private InterstitialAd interstitial;
//    private Button showInterstitialButton;

//    private void Start()
//    {
//        Debug.Log("Request Interstitial Ad");

//        RequestInterstitial();

//        showInterstitialButton = GameObject.Find("Show Interstitial").GetComponent<Button>();

//        showInterstitialButton.onClick.AddListener(() => { if (interstitial.IsLoaded()) interstitial.Show(); });
//    }

//    private void RequestInterstitial()
//    {
//        // Initialize an InterstitialAd.
//        interstitial = new InterstitialAd(adUnitId);
//        // Called when an ad request has successfully loaded.
//        this.interstitial.OnAdLoaded += (sender, args) => Debug.Log("Interstitial is loaded");
//        // Called when an ad request failed to load.
//        this.interstitial.OnAdFailedToLoad += (sender, args) => Debug.Log("Interstitial is not loaded");
//        // Called when an ad is shown.
//        this.interstitial.OnAdOpening += (sender, args) => Debug.Log("Interstitial is Opened");
//        // Called when the ad is closed.
//        this.interstitial.OnAdClosed += (sender, args) => Debug.Log("Interstitial is Closed");
//        // Called when the ad click caused the user to leave the application.
//        this.interstitial.OnAdLeavingApplication += (sender, args) => Debug.Log("Leaving the app");
//        // Create an empty ad request.
//        AdRequest request = new AdRequest.Builder().Build();
//        // Load the interstitial with the request.
//        interstitial.LoadAd(request);
//    }
//}
