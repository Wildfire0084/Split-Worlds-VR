using UnityEngine;
using UnityEngine.UI;

public class ToggleColor : MonoBehaviour
{
    public Material On;
    public Material Off;
    public MeshRenderer Mesh;
    private bool isEnabled = false;
    private Renderer rend;

    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material = Off;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "HandTag")
        {
            isEnabled = !isEnabled;
            rend.material = isEnabled ? On : Off;
        }
    }
}
