﻿using GoogleMobileAds.Api;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdmobAdRewarded : MonoBehaviour
{
    public string adUnitId;

    private RewardedAd rewardedAd;
    private Button showButton;

    private void Start()
    {
        RequestRewarded();

        showButton = GameObject.Find("Show Rewarded").GetComponent<Button>();

        showButton.onClick.AddListener(() => { if (rewardedAd.IsLoaded()) rewardedAd.Show(); });
    }

    private void RequestRewarded()
    {
        rewardedAd = new RewardedAd(adUnitId);
        // Create an empty ad request.
        AdRequest request = new AdRequest.Builder().Build();
        // Load the rewarded ad with the request.
        rewardedAd.LoadAd(request);
        // Called when the user should be rewarded for interacting with the ad.
        this.rewardedAd.OnUserEarnedReward += HandleUserEarnedReward;
    }

    private void HandleUserEarnedReward(object sender, Reward e)
    {
        string type = e.Type;
        double amount = e.Amount;
        Debug.Log("HandleRewardedAdRewarded event received for "
                        + amount.ToString() + " " + type);
    }
}