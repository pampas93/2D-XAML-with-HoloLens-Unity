using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class CheckSubscription : MonoBehaviour {

    public Text textBlock;

    void Start () {
    }

    public void ButtonClickPurchase()
    {
#if !UNITY_EDITOR
        PurchasePanel();
#endif
    }

#if !UNITY_EDITOR
    private async void PurchasePanel()
    {
        var contentPage = Adept.AppViewManager.Views["ContentPage"];
        if (contentPage != null)
        {
            await contentPage.TryShowAsStandaloneAsync();
        }
    }
#endif

    /*
#if !UNITY_EDITOR
public async void ProductDetails() {
   string fulltext = "";

   Windows.ApplicationModel.Store.ListingInformation listing = await Windows.ApplicationModel.Store.CurrentAppSimulator.LoadListingInformationAsync();
   var products = listing.ProductListings;
   foreach(var x in products){
        fulltext += x.Key + " is " + x.Value.FormattedPrice;
    }

    Debug.Log(fulltext);
    textBlock.text = fulltext;
}
#endif */
}
