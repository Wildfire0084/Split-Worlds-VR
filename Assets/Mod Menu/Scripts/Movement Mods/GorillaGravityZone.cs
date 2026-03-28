using GorillaLocomotion;
using UnityEngine;
using easyInputs;

public class GorillaGravityZone : MonoBehaviour
{

    void Start()
    {
        Player.Instance.GetComponent<Rigidbody>().useGravity = true;
    }
    
    void Update()
    {
        if (EasyInputs.GetTriggerButtonDown(EasyHand.RightHand))
        {
            Player.Instance.GetComponent<Rigidbody>().useGravity = false;
        }
        else
        {
            Player.Instance.GetComponent<Rigidbody>().useGravity = true;
        }
    }

    
}