using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.VR;

public class NameSpam : MonoBehaviour
{
    public string localname;

    void Update()
    {
        
        
            localname = "" + Random.Range(1000,9000);
            PhotonVRManager.SetUsername(localname);
        
    }
}
