using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Diagnostics;
using System.ComponentModel;
using System.IO;

public class Blade : MonoBehaviour
{

    private bool slicing = true;

    private Collider collider;

    private Camera mainCamera;

    private TrailRenderer trail;

    public Vector3 direction { get; private set; }

    public float sliceForce = 5f;

    public float minSliceVelo = 0.01f;

    private float curVelo = 0.0f;

    private int mouseProcess;

    public Spawner spawner;

    public Background background;

    public string soundMode = "default";
    public string pitchMode = "diatonic";

    // Start is called before the first frame update
    void Awake()
    {
        collider = GetComponent<Collider>();
        mainCamera = Camera.main;
        trail = GetComponentInChildren<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        
        
        if (slicing) {
            ContinueSlicing();
        }
    
    }

    private void OnEnable() {
        // StopSlicing();
        //mouseProcess = runPy();
    }

    private void OnDisable() {
        StopSlicing();
        //killPy(mouseProcess);
    }

    private void StartSlicing() {
        Vector3 newPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = 0f;

        transform.position = newPos;

        slicing = true;
        collider.enabled = true;
        trail.enabled = true;
        trail.Clear();
    }

    private void StopSlicing() {
        slicing = false;
        collider.enabled = false;
        trail.enabled = false;
    }

    private void ContinueSlicing() {
        Vector3 newPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = 0f;

       //UnityEngine.Debug.Log(transform.position.y);

        direction = newPos - transform.position;

        float velo = direction.magnitude / Time.deltaTime;

        curVelo = velo;

        collider.enabled = velo > minSliceVelo;

        transform.position = newPos;
    }

    private void OnTriggerEnter(Collider fruit) {

        //UnityEngine.Debug.Log(curVelo);

        float curVeloScaled = curVelo / 200f;

        if (curVeloScaled > 1f) {
            curVeloScaled = 1f;
        } else if (curVeloScaled < 0.1f) {
            curVeloScaled = 0.1f;
        }

        if (soundMode == "default") {
            if (fruit.CompareTag("Apple")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    Mandolin m => Gain g => dac;
                    Std.mtof(Math.random2(30, 81)) => m.freq;
                    {0} * 1.2 => g.gain;
                    {0} => float p;
                    if (p < 0.2) {{
                        0.2 => p;
                    }}
                    p => m.pluck;
                    5::second => now;
                ", curVeloScaled));
            }

            if (fruit.CompareTag("Coconut")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    me.dir() + ""handpan.wav"" => string filename;
                    if( me.args() ) me.arg(0) => filename;
                    SndBuf buf => Gain g => dac;
                    {0} * 2 => g.gain;
                    filename => buf.read;
                    0 => buf.pos;
                    buf.length() => now;
                    1::second => now;
                ", curVeloScaled));
            }

            if (fruit.CompareTag("Kiwi")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    ModalBar mb => Gain g => NRev r => dac;
                    0.5 => mb.stickHardness;
                    Std.mtof(Math.random2(40, 81)) => mb.freq;
                    {0} * 2 => g.gain;
                    {0} => float p;
                    if (p < 0.4) {{
                        0.4 => p;
                    }}
                    p => mb.strike;
                    2::second => now;
                ", curVeloScaled));
            }

            if (fruit.CompareTag("Lemon")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    ModalBar mb => Gain g => NRev r => dac;
                    1 => mb.preset;
                    Std.mtof(Math.random2(40, 60)) => mb.freq;
                    {0} * 2 => g.gain;
                    {0} => float p;
                    if (p < 0.3) {{
                        0.3 => p;
                    }}
                    p => mb.strike;
                    3::second => now;
                ", curVeloScaled));
            }

            if (fruit.CompareTag("Lime")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    Shakers mb => Gain g => NRev r => dac;
                    1 => mb.preset;
                    0.8 => mb.energy;
                    {0} * 2 => g.gain;
                    {0} => float p;
                    if (p < 0.3) {{
                        0.3 => p;
                    }}
                    p => mb.noteOn;
                    0.5::second => now;
                    p => mb.noteOff;
                    2::second => now;
                ", curVeloScaled));
            }

            if (fruit.CompareTag("Mango")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    Shakers mb => Gain g => NRev r => dac;
                    3 => mb.preset;
                    {0} * 1.5 => g.gain;
                    {0} => float p;
                    if (p < 0.3) {{
                        0.3 => p;
                    }}
                    p => mb.noteOn;
                    1::second => now;
                    p => mb.noteOff;
                    1::second => now;
                ", curVeloScaled));
            }

            if (fruit.CompareTag("Orange")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    Shakers mb => Gain g => NRev r => dac;
                    5 => mb.preset;
                    0.8 => mb.energy;
                    {0} * 1.6 => g.gain;
                    {0} => float p;
                    if (p < 0.3) {{
                        0.3 => p;
                    }}
                    p => mb.noteOn;
                    0.5::second => now;
                    0.8 => mb.noteOff;
                    2::second => now;
                ", curVeloScaled));
            }

            if (fruit.CompareTag("Watermelon")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    me.dir() + ""basshit.wav"" => string filename;
                    if( me.args() ) me.arg(0) => filename;
                    SndBuf buf => Gain g => dac;
                    {0} * 2 => g.gain;
                    filename => buf.read;
                    0 => buf.pos;
                    buf.length() => now;
                    1::second => now;
                ", curVeloScaled));
            }

            if (fruit.CompareTag("Frenzy")) {
                GetComponent<ChuckSubInstance>().RunCode(@"
                    me.dir() + ""frenzy.wav"" => string filename;
                    if( me.args() ) me.arg(0) => filename;
                    SndBuf buf => Gain g => dac;
                    filename => buf.read;
                    0 => buf.pos;
                    buf.length() => now;
                    1::second => now;
                ");


                if (spawner.spawnMode == "free") {
                    StartCoroutine(spawner.FrenzyTime());
                }
            }

            if (fruit.CompareTag("Freeze")) {
                GetComponent<ChuckSubInstance>().RunCode(@"
                    me.dir() + ""freeze.wav"" => string filename;
                    if( me.args() ) me.arg(0) => filename;
                    SndBuf buf => Gain g => dac;
                    filename => buf.read;
                    0 => buf.pos;
                    buf.length() => now;
                    1::second => now;
                ");

                if (spawner.spawnMode == "free") {
                    StartCoroutine(spawner.FreezeTime());
                }
            }
        } else if (soundMode == "pitched") {
            int pitch = (int) ((transform.position.y + 10f) / 1.66666666f);
            if (pitchMode == "diatonic") {
                if (pitch <= 0) {
                    pitch = 0;
                } else if (pitch == 1) {
                    pitch = 2;
                } else if (pitch == 2) {
                    pitch = 4;
                } else if (pitch == 3) {
                    pitch = 5;
                } else if (pitch == 4) {
                    pitch = 7;
                } else if (pitch == 5) {
                    pitch = 9;
                } else if (pitch == 6) {
                    pitch = 10;
                } else if (pitch == 7) {
                    pitch = 12;
                } else if (pitch == 8) {
                    pitch = 14;
                } else if (pitch == 9) {
                    pitch = 16;
                } else if (pitch == 10) {
                    pitch = 17;
                } else if (pitch >= 11) {
                    pitch = 19;
                }
            }
            
            if (fruit.CompareTag("Apple")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    Mandolin m => Gain g => dac;
                    Std.mtof(50 + {1}) => m.freq;
                    {0} * 1.2 => g.gain;
                    {0} => float p;
                    if (p < 0.2) {{
                        0.2 => p;
                    }}
                    p => m.pluck;
                    5::second => now;
                ", curVeloScaled, pitch));
            }

            if (fruit.CompareTag("Coconut")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    ModalBar mb => Gain g => NRev r => dac;
                    1 => mb.preset;
                    Std.mtof(50 + {1}) => mb.freq;
                    {0} * 2 => g.gain;
                    {0} => float p;
                    if (p < 0.3) {{
                        0.3 => p;
                    }}
                    p => mb.strike;
                    3::second => now;
                ", curVeloScaled, pitch));
            }

            if (fruit.CompareTag("Lemon")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    ModalBar mb => Gain g => NRev r => dac;
                    0.5 => mb.stickHardness;
                    Std.mtof(62 + {1}) => mb.freq;
                    {0} * 3 => g.gain;
                    {0} => float p;
                    if (p < 0.4) {{
                        0.4 => p;
                    }}
                    p => mb.strike;
                    2::second => now;
                ", curVeloScaled, pitch));
            }

            if (fruit.CompareTag("Watermelon")) {
                GetComponent<ChuckSubInstance>().RunCode(string.Format( @"
                    Bowed b => Gain g => NRev r => dac;
    
                    0.1 => r.mix;
                    0.5 => b.bowPressure;
                    Std.mtof(38 + {1}) => b.freq;
        
                    {0} * 1.7 => g.gain;
                    0.3 => b.startBowing;
                    1::second => now;
                    0.3 => b.stopBowing;
                    
                    3::second => now;
                ", curVeloScaled, pitch));
            }

            if (fruit.CompareTag("Frenzy")) {
                GetComponent<ChuckSubInstance>().RunCode(@"
                    me.dir() + ""frenzy.wav"" => string filename;
                    if( me.args() ) me.arg(0) => filename;
                    SndBuf buf => Gain g => dac;
                    filename => buf.read;
                    0 => buf.pos;
                    buf.length() => now;
                    1::second => now;
                ");


                if (spawner.spawnMode == "free") {
                    StartCoroutine(spawner.FrenzyTime());
                }
            }

            if (fruit.CompareTag("Freeze")) {
                GetComponent<ChuckSubInstance>().RunCode(@"
                    me.dir() + ""freeze.wav"" => string filename;
                    if( me.args() ) me.arg(0) => filename;
                    SndBuf buf => Gain g => dac;
                    filename => buf.read;
                    0 => buf.pos;
                    buf.length() => now;
                    1::second => now;
                ");

                if (spawner.spawnMode == "free") {
                    StartCoroutine(spawner.FreezeTime());
                }
            }
        }
        
    }

/*
    private int runPy()
    {
        string pyCmd = "python3.7 /Users/jxiao1/Documents/STANNY/Autumn 2022/256A/fp/python_handtrack/virtual_mouse.py";
        ProcessStartInfo startInfo = new ProcessStartInfo() { FileName = "/bin/zsh", Arguments = pyCmd, };
        Process p = System.Diagnostics.Process.Start(startInfo);
        UnityEngine.Debug.Log(p.Id);
        p.Kill();
        return p.Id;
    }

    private void killPy(int id) {
        Process p = Process.GetProcessById(id);
        p.Kill();
    }
    */
}


/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blade : MonoBehaviour
{

    private bool slicing = false;

    private Collider collider;

    private Camera mainCamera;

    private TrailRenderer trail;

    public Vector3 direction { get; private set; }

    public float sliceForce = 5f;

    public float minSliceVelo = 0.01f;


    // Start is called before the first frame update
    void Awake()
    {
        collider = GetComponent<Collider>();
        mainCamera = Camera.main;
        trail = GetComponentInChildren<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        
        
        if (Input.GetMouseButtonDown(0)) {
            StartSlicing();
        } else if (Input.GetMouseButtonUp(0)) {
            StopSlicing();
        } else if (slicing) {
            ContinueSlicing();
        }
        
    }

    private void OnEnable() {
        StopSlicing();
    }

    private void OnDisable() {
        StopSlicing();
    }

    private void StartSlicing() {
        Vector3 newPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = 0f;

        transform.position = newPos;

        slicing = true;
        collider.enabled = true;
        trail.enabled = true;
        trail.Clear();
    }

    private void StopSlicing() {
        slicing = false;
        collider.enabled = false;
        trail.enabled = false;
    }

    private void ContinueSlicing() {
        Vector3 newPos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        newPos.z = 0f;

        direction = newPos - transform.position;

        float velo = direction.magnitude / Time.deltaTime;

        collider.enabled = velo > minSliceVelo;

        transform.position = newPos;
    }

    private void OnTriggerEnter(Collider fruit) {
        if (fruit.CompareTag("Apple")) {
            GetComponent<ChuckSubInstance>().RunCode(@"
                Mandolin m => NRev r => dac;
                Std.mtof(Math.random2(30, 81)) => m.freq;
                0.7 => m.pluck;
                3::second => now;
		    ");
        }

        if (fruit.CompareTag("Coconut")) {
            GetComponent<ChuckSubInstance>().RunCode(@"
                me.dir() + ""handpan.wav"" => string filename;
                if( me.args() ) me.arg(0) => filename;
                SndBuf buf => Gain g => dac;
                filename => buf.read;
                0 => buf.pos;
                buf.length() => now;
                1::second => now;
		    ");
        }

        if (fruit.CompareTag("Kiwi")) {
            GetComponent<ChuckSubInstance>().RunCode(@"
                ModalBar mb => Gain g => NRev r => dac;
                0.5 => mb.stickHardness;
                Std.mtof(Math.random2(40, 81)) => mb.freq;
                0.8 => mb.strike;
                2::second => now;
		    ");
        }

        if (fruit.CompareTag("Lemon")) {
            GetComponent<ChuckSubInstance>().RunCode(@"
                ModalBar mb => Gain g => NRev r => dac;
                1 => mb.preset;
                Std.mtof(Math.random2(40, 60)) => mb.freq;
                0.8 => mb.strike;;
                1::second => now;
		    ");
        }

        if (fruit.CompareTag("Lime")) {
            GetComponent<ChuckSubInstance>().RunCode(@"
                Bowed mb => Gain g => NRev r => dac;
                Std.mtof(Math.random2(30, 70)) => mb.freq;
                0.8 => mb.startBowing;
                1::second => now;
                0.8 => mb.stopBowing;
                1::second => now;
		    ");
        }

        if (fruit.CompareTag("Mango")) {
            GetComponent<ChuckSubInstance>().RunCode(@"
                Shakers mb => Gain g => NRev r => dac;
                1 => mb.preset;
                0.8 => mb.energy;
                0.8 => mb.noteOn;
                0.5::second => now;
                0.8 => mb.noteOff;
                2::second => now;
		    ");
        }

        if (fruit.CompareTag("Orange")) {
            GetComponent<ChuckSubInstance>().RunCode(@"
                Shakers mb => Gain g => NRev r => dac;
                5 => mb.preset;
                0.8 => mb.energy;
                0.8 => mb.noteOn;
                0.5::second => now;
                0.8 => mb.noteOff;
                2::second => now;
		    ");
        }

        if (fruit.CompareTag("Watermelon")) {
            GetComponent<ChuckSubInstance>().RunCode(@"
                Shakers mb => Gain g => NRev r => dac;
                3 => mb.preset;
                0.8 => mb.noteOn;
                1::second => now;
                0.8 => mb.noteOff;
                1::second => now;
		    ");
        }
    }
}
*/