using UnityEngine;
using UnityEngine.UI;

public class ToggleButton : MonoBehaviour
{
    public GameObject objectToToggle;
    private bool isEnabled = false;

    public void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "HandTag")
        {
            isEnabled = !isEnabled;
            objectToToggle.SetActive(isEnabled);
        }
    }
}
