using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdmobInit : MonoBehaviour
{

    public string appID;
    public Button initButton;
    //public string bannerAdUnitID;
    //public string interstitialAdUnitId;
    //public string rewardedAdUnitId;

    //private BannerView bannerView;
    //private Button showBannerButton;
    //private Button closeButton;

    //private RewardedAd rewardedAd;
    //private Button showButton;

    //private InterstitialAd interstitial;
    //private Button showInterstitialButton;

    void Awake()
    {

        MobileAds.Initialize(appID);

        AdmobAdBanner banner = GetComponent<AdmobAdBanner>();
        AdmobAdInterstitial interstitial = GetComponent<AdmobAdInterstitial>();
        AdmobAdRewarded rewarded = GetComponent<AdmobAdRewarded>();
        AdmobAdNative native = GetComponent<AdmobAdNative>();

        initButton.onClick.AddListener(() =>
        {
            //StartCoroutine(SkipOneFrame(() =>
            //{
            Debug.Log("Init Ad Unit");
            banner.Init();
            interstitial.Init();
            rewarded.Init();
            native.Init();
            //}));
        });

        //InitBanner();
        //InitInterstitial();
        //InitRewardedAds();
    }

    //private IEnumerator SkipOneFrame(System.Action OnCompleted)
    //{
    //    yield return null;
    //    OnCompleted?.Invoke();
    //}

    //#region Banner
    //private void InitBanner()
    //{
    //    Debug.Log("Request Banner Ad");

    //    RequestBanner();

    //    showBannerButton = GameObject.Find("Show Banner").GetComponent<Button>();
    //    closeButton = GameObject.Find("Close Banner").GetComponent<Button>();

    //    showBannerButton.onClick.AddListener(() => bannerView.Show());
    //    closeButton.onClick.AddListener(() => bannerView.Destroy());
    //}

    //private void RequestBanner()
    //{
    //    // Create a 320x50 banner at the top of the screen
    //    bannerView = new BannerView(bannerAdUnitID, AdSize.Banner, AdPosition.Bottom);
    //    bannerView.OnAdLoaded += (sender, args) => Debug.Log("Banner Ad Loaded");
    //    bannerView.OnAdFailedToLoad += (sender, args) => Debug.Log("Banner Ad Failed to Load: " + args.Message);
    //    bannerView.OnAdOpening += (sender, args) => Debug.Log("Banner Ad Opened");
    //    bannerView.OnAdClosed += (sender, args) => Debug.Log("Banner Ad Closed");
    //    bannerView.OnAdLeavingApplication += (sender, args) => Debug.Log("Banner Leaving App");

    //    // Create an empty ad request
    //    AdRequest request = new AdRequest.Builder().Build();
    //    // Load the banner with the request
    //    bannerView.LoadAd(request);
    //    bannerView.Show();
    //}
    //#endregion

    //#region Interstitial
    //private void InitInterstitial()
    //{
    //    Debug.Log("Request Interstitial Ad");

    //    RequestInterstitial();

    //    showInterstitialButton = GameObject.Find("Show Interstitial").GetComponent<Button>();

    //    showInterstitialButton.onClick.AddListener(() => { if (interstitial.IsLoaded()) interstitial.Show(); });
    //}

    //private void RequestInterstitial()
    //{
    //    // Initialize an InterstitialAd.
    //    interstitial = new InterstitialAd(interstitialAdUnitId);
    //    // Called when an ad request has successfully loaded.
    //    this.interstitial.OnAdLoaded += (sender, args) => Debug.Log("Interstitial is loaded");
    //    // Called when an ad request failed to load.
    //    this.interstitial.OnAdFailedToLoad += (sender, args) => Debug.Log("Interstitial is not loaded: " + args.Message);
    //    // Called when an ad is shown.
    //    this.interstitial.OnAdOpening += (sender, args) => Debug.Log("Interstitial is Opened");
    //    // Called when the ad is closed.
    //    this.interstitial.OnAdClosed += (sender, args) => Debug.Log("Interstitial is Closed");
    //    // Called when the ad click caused the user to leave the application.
    //    this.interstitial.OnAdLeavingApplication += (sender, args) => Debug.Log("Leaving the app");
    //    // Create an empty ad request.
    //    AdRequest request = new AdRequest.Builder().Build();
    //    // Load the interstitial with the request.
    //    interstitial.LoadAd(request);
    //}
    //#endregion

    //#region Rewarded
    //private void InitRewardedAds()
    //{
    //    Debug.Log("Request Rewarded Ad");

    //    RequestRewarded();

    //    showButton = GameObject.Find("Show Rewarded").GetComponent<Button>();

    //    showButton.onClick.AddListener(() => { if (rewardedAd.IsLoaded()) rewardedAd.Show(); });
    //}

    //private void RequestRewarded()
    //{
    //    rewardedAd = new RewardedAd(rewardedAdUnitId);
    //    // Called when an ad request has successfully loaded.
    //    this.rewardedAd.OnAdLoaded += (sender, args) => Debug.Log("Rewarded is Loaded");
    //    // Called when an ad request failed to load.
    //    this.rewardedAd.OnAdFailedToLoad += (sender, args) => Debug.Log("Rewarded is not loaded: " + args.Message);
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
    //#endregion
}
