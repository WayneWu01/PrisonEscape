using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RemoteNumberCode : MonoBehaviour
{
    [SerializeField] ActiveSync tvVideo;
    [SerializeField] ActiveSync lock1;
    [SerializeField] ActiveSync lock2;
    [SerializeField] ActiveSync lock3;
    [SerializeField] ActiveSync lock4;

    int[] correctCode = new int[] { 4, 2, 1, 2 };
    int idx = 0;

    // Start is called before the first frame update
    void Start()
    {
        tvVideo.SetActive(false);
        lock1.SetActive(false);
        lock2.SetActive(false);
        lock3.SetActive(false);
        lock4.SetActive(false);
    }

    public void PressedNumber(int number)
    {
        if (number == correctCode[idx])
        {
            ++idx;
            if (idx == 4)
            {
                tvVideo.SetActive(true);
                lock1.SetActive(true);
                lock2.SetActive(true);
                lock3.SetActive(true);
                lock4.SetActive(true);
            }
        }
        else
        {
            if (number == correctCode[0])
            {
                idx = 1;
            }
            else
            {
                idx = 0;
            }
        }
    }
}
