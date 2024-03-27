using UnityEngine;
using System.Collections;

public class AdController : MonoBehaviour
{
    // Use this for initialization
    public AdmobController Admob;
    public UnityAdController UnityAd;

    [HideInInspector] public bool isRemoveAd;

    [Header("Banner Ad Settings")] public bool isShowBannerAd = true;
    [Space(5)] public string androidBannerAdID = "";
    public string iOsBannerAdID = "";
    public string windowPhoneBannerAdID = "";

    public enum PositionBannerAd
    {
        Top,
        Bottom,
        BothTopAndBottom
    }

    public PositionBannerAd positionBannerAd = PositionBannerAd.Top;

    public enum ShowBannerAdWhen
    {
        AllTime,
        OnlyWhenLevelComplete,
        OnlyInMenu,
        OnlyInMenuAndLevelComplete,
        OnlyInGameplay
    }

    public ShowBannerAdWhen showBannerWhen = ShowBannerAdWhen.AllTime;

    [Space(10)] [Header("Interstitial Ad Setting")]
    public bool isShowInterstitialAd = true;

    [Space(5)] public string androidInterAdID = "";
    public string iOsInterAdID = "";
    public string windowPhoneInterAdID = "";

    public enum ShowInterstinialAdWhen
    {
        WhenLevelComplete,
        WhenStartLevel
    }

    [Tooltip("Condition to show Interstinial Ad")]
    public ShowInterstinialAdWhen showInterstinialAdWhen = ShowInterstinialAdWhen.WhenLevelComplete;

    public int timesPlayToShowInterstinialAd = 3;
    public int timesLevelCompleteToShowInterstinialAd = 2;

    [Space(10)] [Header("Unity Ad Setting")]
    public bool isShowUnityAd = true;

    [Space(5)] public string androidGameID = "";
    public string iOsGameID = "";
    public string zone = "rewardedVideo";

    public enum ShowUnityAdWhen
    {
        WhenLevelComplete,
        WhenStartLevel
    }

    [Tooltip("Condition to show Unity Ad")]
    public ShowUnityAdWhen showUnityAdWhen = ShowUnityAdWhen.WhenLevelComplete;

    public int timesPlayToShowUnityAd = 5;
    public int timesLevelCompleteToShowUnityAd = 3;

    [Space(10)] [Header("For Auto Show Remove Ad")]
    public bool isAutoShowRemoveAd = true;

    public enum ShowRemoveAdWhen
    {
        AfterInterAd,
        AfterUnityAd,
        AfterInterAdOrUnityAd,
        AfterTimesInterAd,
        AfterTimesUnityAd,
    }

    public ShowRemoveAdWhen showRemoveAdWhen = ShowRemoveAdWhen.AfterUnityAd;
    public int timesShowInterAdToShowRemoveAd = 2;
    public int timesShowUnityToShowRemoveAd = 2;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        if (Master.Ad != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Master.Ad = this;
            Admob = FindObjectOfType<AdmobController>();
            UnityAd = FindObjectOfType<UnityAdController>();
        }

        CheckRemoveAd();
    }

    public void CheckRemoveAd()
    {
    }

    public bool CheckAndShowAd(System.Action onCompleteShowAd = null)
    {
        return true;
    }

    public bool CheckShowRemoveAd(string type, System.Action onComplete = null)
    {
        return true;
    }

    #region Banner Ad Controller

    void BannerAdController()
    {
    }

    private void ShowBanner()
    {
    }

    #endregion

    #region Interstinial Ad Controller

    bool InterstinialAdController(System.Action onCompleteShowAd = null)
    {
        return true;
    }

    #endregion

    #region Unity Ad Controller

    bool UnityAdController(System.Action onCompleteShowAd = null)
    {
        return true;
    }

    #endregion
}