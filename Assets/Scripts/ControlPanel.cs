using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPanel : MonoBehaviour
{

    public Spawner spawner;
    public Blade blade;
    public CanvasScript cs;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        
        if (Input.GetKeyDown(KeyCode.Q)) {
            Debug.Log("q pressed");
            spawner.stopFreeplay();
            cs.setPlayModeKey();
        }

        if (Input.GetKeyDown(KeyCode.S)) {
            Debug.Log("s pressed");
            blade.soundMode = "default";
            cs.setSoundModeDefault();
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            Debug.Log("w pressed");
            blade.soundMode = "pitched";
            cs.setSoundModePitched();
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            Debug.Log("D pressed");
            blade.pitchMode = "diatonic";
            cs.setScaleModeDiatonic();
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            Debug.Log("E pressed");
            blade.pitchMode = "chromatic";
            cs.setScaleModeChromatic();
        }
    }
}
