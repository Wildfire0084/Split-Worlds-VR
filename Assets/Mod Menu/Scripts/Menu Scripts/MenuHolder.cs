using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuHolder : MonoBehaviour
{

    public Transform Placement;
    public Transform Menu;

    void Update() 
    {
        Menu.transform.position = Placement.position;
        Menu.transform.rotation = Placement.rotation;
    }
}
