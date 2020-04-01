using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdmobAdBanner : MonoBehaviour
{
    public string adUnitID;

    private BannerView bannerView;
    private Button showButton;
    private Button closeButton;

    public void Init()
    {
        Debug.Log("Init Banner Ad");

        RequestBanner();

        showButton = GameObject.Find("Show Banner").GetComponent<Button>();
        closeButton = GameObject.Find("Close Banner").GetComponent<Button>();

        showButton.onClick.AddListener(() => bannerView.Show());
        closeButton.onClick.AddListener(() => bannerView.Destroy());
    }

    public void RequestBanner()
    {
        Debug.Log("Request Banner Ad");

        // Create a 320x50 banner at the top of the screen
        bannerView = new BannerView(adUnitID, AdSize.Banner, AdPosition.Bottom);
        bannerView.OnAdLoaded += (sender, args) => Debug.Log("Banner Ad Loaded");
        bannerView.OnAdFailedToLoad += (sender, args) => Debug.Log("Banner Ad Failed to Load: " + args.Message);
        bannerView.OnAdOpening += (sender, args) => Debug.Log("Banner Ad Opened");
        bannerView.OnAdClosed += (sender, args) => Debug.Log("Banner Ad Closed");
        bannerView.OnAdLeavingApplication += (sender, args) => Debug.Log("Banner Leaving App");

        // Create an empty ad request
        AdRequest request = new AdRequest.Builder().Build();
        // Load the banner with the request
        bannerView.LoadAd(request);
        bannerView.Show();
    }
}
