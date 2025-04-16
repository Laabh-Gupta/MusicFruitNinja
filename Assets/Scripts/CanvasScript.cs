using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CanvasScript : MonoBehaviour
{

    public TextMeshProUGUI playText;
    public TextMeshProUGUI soundText;
    public TextMeshProUGUI scaleText;
    public TextMeshProUGUI scoreText;

    private int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore(int points)
    {
        score += points;
        UpdateScoreText();
    }

    private void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score;
        }
    }

    public void setPlayModeFree() {
        playText.text = "play mode: auto";
    }

    public void setPlayModeKey() {
        playText.text = "play mode: keyboard";
    }

    public void setSoundModeDefault() {
        soundText.text = "sound mode: default";
    }

    public void setSoundModePitched() {
        soundText.text = "sound mode: pitched";
    }

    public void setScaleModeChromatic() {
        scaleText.text = "scale: chromatic";
    }

    public void setScaleModeDiatonic() {
        scaleText.text = "scale: diatonic";
    }
}
