//using GoogleMobileAds.Api;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.UI;

//public class AdmobAdRewarded : MonoBehaviour
//{
//    public string adUnitId;

//    private RewardedAd rewardedAd;
//    private Button showButton;

//    private void Start()
//    {
//        Debug.Log("Request Rewarded Ad");

//        RequestRewarded();

//        showButton = GameObject.Find("Show Rewarded").GetComponent<Button>();

//        showButton.onClick.AddListener(() => { if (rewardedAd.IsLoaded()) rewardedAd.Show(); });
//    }

    //private void RequestRewarded()
    //{
    //    rewardedAd = new RewardedAd(adUnitId);
    //    // Called when an ad request has successfully loaded.
    //    this.rewardedAd.OnAdLoaded += (sender, args) => Debug.Log("Rewarded is Loaded");
    //    // Called when an ad request failed to load.
    //    this.rewardedAd.OnAdFailedToLoad += (sender, args) => Debug.Log("Rewarded is not loaded");
    //    // Called when an ad is shown.
    //    this.rewardedAd.OnAdOpening += (sender, args) => Debug.Log("Rewarded is opened");
    //    // Called when an ad request failed to show.
    //    this.rewardedAd.OnAdFailedToShow += (sender, args) => Debug.Log("Rewarded is failed to show");
    //    // Called when the user should be rewarded for interacting with the ad.
    //    this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    //    // Called when the ad is closed.
    //    this.rewardedAd.OnAdClosed += (sender, args) => Debug.Log("Rewarded is closed");
    //    // Create an empty ad request.
    //    AdRequest request = new AdRequest.Builder().Build();
    //    // Load the rewarded ad with the request.
    //    rewardedAd.LoadAd(request);
    //    // Called when the user should be rewarded for interacting with the ad.
    //}

    //private void HandleUserEarnedReward(object sender, Reward e)
    //{
    //    string type = e.Type;
    //    double amount = e.Amount;
    //    Debug.Log("HandleRewardedAdRewarded event received for "
    //                    + amount.ToString() + " " + type);
    //}
//}
