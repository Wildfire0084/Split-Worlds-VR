using UnityEngine;
using PlayFab;
using PlayFab.ClientModels;
using System.Collections.Generic;

public class RhezzysTouchCurrency : MonoBehaviour
{
 
    [System.Serializable]
    public class CurrencyGrant
    {
        public string currencyCode = "WS"; // e.g., "WS", "WS"
        public int amount = 100;
    }

    [Header("Currency Settings")]
    public List<CurrencyGrant> currenciesToGrant = new List<CurrencyGrant>();

    [Header("Hand Interaction")]
    public string triggeringTag = "HandTag";

    private bool hasGranted = false;

    private void OnTriggerEnter(Collider other)
    {
        if (!hasGranted && other.CompareTag(triggeringTag))
        {
            GrantCurrencies();
        }
    }

    private void GrantCurrencies()
    {
        foreach (var grant in currenciesToGrant)
        {
            if (!string.IsNullOrEmpty(grant.currencyCode) && grant.amount != 0)
            {
                var request = new AddUserVirtualCurrencyRequest
                {
                    VirtualCurrency = grant.currencyCode,
                    Amount = grant.amount
                };

                PlayFabClientAPI.AddUserVirtualCurrency(request,
                    result =>
                    {
                        Debug.Log($"✅ RhezzysTouchCurrency: Granted {grant.amount} {grant.currencyCode}.");
                        hasGranted = true;
                    },
                    error =>
                    {
                        Debug.LogError("❌ RhezzysTouchCurrency: Failed to grant currency:\n" + error.GenerateErrorReport());
                    });
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(triggeringTag))
        {
            hasGranted = false;
        }
    }
}
