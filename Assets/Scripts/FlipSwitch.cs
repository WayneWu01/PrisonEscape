using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class FlipSwitch : MonoBehaviour
{
    //public Light lightCode;
    public GameObject orangeSwitch;
    public GameObject purpleSwitch;
    public GameObject blueSwitch;
    //public GameObject nextPuzzle;

    private LightSync lightSync;
    private FlushTextSync textSync;

    private Realtime _realtime;
    private RealtimeAvatarManager _avatarManager;

    public AudioSource clickSound;

    //private bool isOn = false;

    private IDictionary<Color, bool> switchFlipped = new Dictionary<Color, bool>()
    {
        { Color.yellow, false },
        { Color.magenta, false },
        { Color.cyan, false }
    };

    // Start is called before the first frame update
    void Start()
    {
        _realtime = FindObjectOfType<Realtime>();
        _avatarManager = _realtime.GetComponent<RealtimeAvatarManager>();

        lightSync = FindObjectOfType<LightSync>();
        textSync = FindObjectOfType<FlushTextSync>();

        // start all switches off
        orangeSwitch.transform.Rotate(90, 0, 0);
        purpleSwitch.transform.Rotate(90, 0, 0);
        blueSwitch.transform.Rotate(90, 0, 0);
        lightSync.SetLight(false); //lightCode.enabled = false;
        textSync.SetText("");  //nextPuzzle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (_realtime.clientID % 2 == 0)
        {
            if (switchFlipped[Color.yellow]
            && !switchFlipped[Color.magenta]
            && !switchFlipped[Color.cyan])
            {
                lightSync.SetLight(true); //lightCode.enabled = true;
                lightSync.SetColor(Color.yellow); //lightCode.color = Color.yellow;
                textSync.SetText(""); //nextPuzzle.SetActive(false);
            }
            else if (!switchFlipped[Color.yellow]
                && switchFlipped[Color.magenta]
                && !switchFlipped[Color.cyan])
            {
                lightSync.SetLight(true); //lightCode.enabled = true;
                lightSync.SetColor(Color.magenta); //lightCode.color = Color.magenta;
                textSync.SetText(""); //nextPuzzle.SetActive(false);
            }
            else if (!switchFlipped[Color.yellow]
                && !switchFlipped[Color.magenta]
                && switchFlipped[Color.cyan])
            {
                lightSync.SetLight(true); //lightCode.enabled = true;
                lightSync.SetColor(Color.cyan); //lightCode.color = Color.cyan;
                textSync.SetText(""); //nextPuzzle.SetActive(false);
            }
            else if (switchFlipped[Color.magenta] && switchFlipped[Color.cyan])
            {
                lightSync.SetLight(true); //lightCode.enabled = true;
                lightSync.SetColor(Color.green); //lightCode.color = Color.green;
                textSync.SetText("F L U S H"); //nextPuzzle.SetActive(true);
            }
            else
            {
                textSync.SetText(""); //nextPuzzle.SetActive(false);
                lightSync.SetLight(false); //lightCode.enabled = false;
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("orangeSwitch"))
        {
            if (switchFlipped[Color.yellow])
            {
                other.gameObject.transform.Rotate(90, 0, 0);
            }
            else
            {
                other.gameObject.transform.Rotate(-90, 0, 0);
            }
            switchFlipped[Color.yellow] = !switchFlipped[Color.yellow];
            clickSound.Play();
        }
        if (other.gameObject.CompareTag("purpleSwitch"))
        {
            if (switchFlipped[Color.magenta])
            {
                other.gameObject.transform.Rotate(90, 0, 0);
            }
            else
            {
                other.gameObject.transform.Rotate(-90, 0, 0);
            }
            switchFlipped[Color.magenta] = !switchFlipped[Color.magenta];
            clickSound.Play();

        }
        if (other.gameObject.CompareTag("blueSwitch"))
        {
            if (switchFlipped[Color.cyan])
            {
                other.gameObject.transform.Rotate(90, 0, 0);
            }
            else
            {
                other.gameObject.transform.Rotate(-90, 0, 0);
            }
            switchFlipped[Color.cyan] = !switchFlipped[Color.cyan];
            clickSound.Play();
        }

    }

    IEnumerator Delay(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }

}
