using UnityEngine;
using TMPro;

public class OnlyUp : MonoBehaviour
{
    public TextMeshPro textMesh;

    private float currentHeight;
    private float highScore;

    void Start()
    {
        if (textMesh == null)
        {
            Debug.LogError("TextMeshPro reference is not set. Please assign a TextMeshPro object.");
            return;
        }

        currentHeight = transform.position.y;
        highScore = currentHeight;

        UpdateText();
    }

    void Update()
    {
        currentHeight = transform.position.y;

        highScore = Mathf.Max(highScore, currentHeight);

        UpdateText();
    }

    void UpdateText()
    {
        textMesh.text = "Current Height: " + currentHeight.ToString("F2") +
                        "\nHigh Score: " + highScore.ToString("F2");
    }
}