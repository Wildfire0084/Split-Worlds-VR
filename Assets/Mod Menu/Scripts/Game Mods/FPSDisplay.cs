using UnityEngine;
using TMPro;

public class FPSDisplay : MonoBehaviour
{
    public float updateInterval = 0.2f;
    private float accum = 0.0f;
    private int frames = 0;
    private float timeleft;
    private TextMeshPro fpsText;

    private void Start()
    {
        fpsText = GetComponent<TextMeshPro>();
        if (fpsText == null)
        {
            Debug.LogError("FPSDisplay: No Text Found Try Again");
        }
        timeleft = updateInterval;
    }

    private void Update()
    {
        timeleft -= Time.deltaTime;
        accum += Time.timeScale / Time.deltaTime;
        ++frames;

        if (timeleft <= 0.0)
        {
            float fps = accum / frames;
            fpsText.text = string.Format("FPS: {0:0}", fps);

            timeleft = updateInterval;
            accum = 0.0f;
            frames = 0;
        }
    }
}