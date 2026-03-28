using UnityEngine;
using Photon.Pun;
using Photon.VR;
using easyInputs;

public class SecondaryDisconnect : MonoBehaviour
{
    void Start()
    {
        if (EasyInputs.GetSecondaryButtonDown(EasyHand.RightHand))
        {
            PhotonNetwork.Disconnect();
        }
        else
        if (EasyInputs.GetSecondaryButtonDown(EasyHand.LeftHand))
        {
            PhotonNetwork.Disconnect();
        }
    }
}
