using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.VR;

public class Disconnect : MonoBehaviour
{
    public string Tag = "HandTag";
    
    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == (Tag))
        {
            PhotonNetwork.Disconnect();
        }
        
    }
}
