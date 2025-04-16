using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LineScript : MonoBehaviour
{

    public GameObject line;
    private bool active = false;

    public Blade blade;

    public TextMeshProUGUI a;
    public TextMeshProUGUI b;
    public TextMeshProUGUI c;
    public TextMeshProUGUI d;
    public TextMeshProUGUI e;
    public TextMeshProUGUI f;
    public TextMeshProUGUI g;
    public TextMeshProUGUI h;
    public TextMeshProUGUI i;
    public TextMeshProUGUI j;
    public TextMeshProUGUI k;
    public TextMeshProUGUI l;

    // Start is called before the first frame update
    void Start()
    {
        line.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L)) {
            if (active) {
                active = false;
                line.SetActive(false);
            } else {
                active = true;
                line.SetActive(true);
            }
        }

        if (Input.GetKeyDown(KeyCode.D)) {
            a.text = "D";
            b.text = "E";
            c.text = "F#";
            d.text = "G";
            e.text = "A";
            f.text = "B";
            g.text = "C";
            h.text = "D";
            i.text = "E";
            j.text = "F#";
            k.text = "G";
            l.text = "A";
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            a.text = "D";
            b.text = "D#";
            c.text = "E";
            d.text = "F";
            e.text = "F#";
            f.text = "G";
            g.text = "G#";
            h.text = "A";
            i.text = "A#";
            j.text = "B";
            k.text = "C";
            l.text = "C#";
        }
    }


}
