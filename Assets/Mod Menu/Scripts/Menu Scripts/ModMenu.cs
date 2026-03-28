using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using easyInputs;
public class ModMenu : MonoBehaviour
{
    public GameObject Menu;
 
    
    void Update()
    {
        Menu.SetActive(EasyInputs.GetPrimaryButtonDown(EasyHand.LeftHand));
    }
}
