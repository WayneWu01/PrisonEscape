using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireScript : MonoBehaviour
{
    [SerializeField] GameObject fire;
    // code is 4212 (also accepts 5323)

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("FireFourSeconds", 0f, 23.0f);
        InvokeRepeating("FireTwoSeconds", 7.0f, 23.0f);
        InvokeRepeating("FireOneSecond", 11.0f, 23.0f);
        InvokeRepeating("FireTwoSeconds", 14.0f, 23.0f);
    }

    void FireFourSeconds()
    {
        fire.SetActive(true);
        StartCoroutine(WaitThenTurnOff(5.0f));
    }

    void FireTwoSeconds()
    {
        fire.SetActive(true);
        StartCoroutine(WaitThenTurnOff(3.0f));
    }

    void FireOneSecond()
    {
        fire.SetActive(true);
        StartCoroutine(WaitThenTurnOff(2.0f));
    }

    IEnumerator WaitThenTurnOff(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        fire.SetActive(false);
    }

}
