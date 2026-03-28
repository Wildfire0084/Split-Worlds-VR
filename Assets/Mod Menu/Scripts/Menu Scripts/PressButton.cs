using UnityEngine;
using UnityEngine.UI;

public class PressButton : MonoBehaviour
{
    public GameObject objectToTurnOn;
    public GameObject objectToTurnOff;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "HandTag")
        {
            objectToTurnOn.SetActive(true);
            objectToTurnOff.SetActive(false);
        }
    }
}
