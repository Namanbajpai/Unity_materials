using GoogleMobileAds.Api;
using UnityEngine;
using System;
public class AdManager : MonoBehaviour
{
    private void Start()
    {
        // Initialize the Google Mobile Ads SDK.
        MobileAds.Initialize(initStatus => { });
    }
}
