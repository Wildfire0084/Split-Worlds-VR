using UnityEngine;
using TMPro;
using PlayFab;
using PlayFab.ClientModels;

public class DisplayPlayFabID : MonoBehaviour
{
    [Header("Made by Razzle")]
    [Header("No credits needed")]
    public TextMeshPro playFabIDText;
    void Start()
    {
        
        LoginPlayer();
    }

    void LoginPlayer()
    {
        
        PlayFabClientAPI.LoginWithCustomID(new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true  
        },
        result => {
            
            Debug.Log("Logged in successfully!");
            GetPlayFabID();
        },
        error => {
            
            Debug.LogError("Error logging in: " + error.GenerateErrorReport());
        });
    }

    void GetPlayFabID()
    {
        
        if (PlayFabClientAPI.IsClientLoggedIn())
        {
            
            var request = new GetAccountInfoRequest();
            PlayFabClientAPI.GetAccountInfo(request, OnGetAccountInfoSuccess, OnPlayFabError);
        }
        else
        {
            Debug.LogError("Not logged in to PlayFab.");
        }
    }

    
    private void OnGetAccountInfoSuccess(GetAccountInfoResult result)
    {
        if (result != null && result.AccountInfo != null)
        {
            
            Debug.Log("PlayFab ID: " + result.AccountInfo.PlayFabId);
            
            playFabIDText.text = "PlayFab ID: " + result.AccountInfo.PlayFabId;
        }
        else
        {
            Debug.LogError("PlayFab account info is missing.");
        }
    }

    
    private void OnPlayFabError(PlayFabError error)
    {
        Debug.LogError("Error getting PlayFab account info: " + error.GenerateErrorReport());
    }
}
