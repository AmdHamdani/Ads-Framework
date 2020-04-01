using GoogleMobileAds.Api;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdmobAdNative : MonoBehaviour
{
    public string adUnitId;
    public GameObject adNativePanel;
    public RawImage adIcon;
    public RawImage adChoiceIcon;
    public Text adHeadline;
    public Text adAdvertiser;
    public Text AdCta;

    private bool unifiedNativeAdLoaded;
    private UnifiedNativeAd nativeAd;

    public void Awake()
    {
        adNativePanel.SetActive(false);
    }

    public void Init()
    {
        Debug.Log("Init & Request Native Ad");

        AdLoader adLoader = new AdLoader.Builder(adUnitId).ForUnifiedNativeAd().Build();
        adLoader.OnUnifiedNativeAdLoaded += (sender, args) =>
        {
            Debug.Log("Unified Native ad loaded");
            nativeAd = args.nativeAd;
            unifiedNativeAdLoaded = true;
        };
        adLoader.OnAdFailedToLoad += (sender, args) => Debug.Log("Native Ad Failed to load");
        adLoader.LoadAd(new AdRequest.Builder().Build());
    }

    public void Update()
    {
        if (unifiedNativeAdLoaded)
        {
            unifiedNativeAdLoaded = false;
            Texture2D iconTexture = nativeAd.GetIconTexture();
            Texture2D iconAdChoice = nativeAd.GetAdChoicesLogoTexture();
            string headline = nativeAd.GetHeadlineText();
            string advertiser = nativeAd.GetAdvertiserText();
            string cta = nativeAd.GetCallToActionText();

            adIcon.texture = iconTexture;
            adChoiceIcon.texture = iconAdChoice;
            adHeadline.text = headline;
            adAdvertiser.text = advertiser;
            AdCta.text = cta;

            nativeAd.RegisterIconImageGameObject(adIcon.gameObject);
            nativeAd.RegisterAdChoicesLogoGameObject(adChoiceIcon.gameObject);
            nativeAd.RegisterHeadlineTextGameObject(adHeadline.gameObject);
            nativeAd.RegisterAdvertiserTextGameObject(adAdvertiser.gameObject);
            nativeAd.RegisterCallToActionGameObject(AdCta.gameObject);

            adNativePanel.SetActive(true);
        }
    }
}
