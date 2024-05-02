using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using TMPro;

public class NumberCode : MonoBehaviour
{
    [SerializeField] GameObject keypad;
    [SerializeField] GameObject chest;

    [SerializeField] private Animator chestAnimator;
    private AudioSource _audioSource;

    int[] correctCode = new int[] { 5, 3, 4, 1 };
    int idx = 0;

    private bool opened;

    // Start is called before the first frame update
    void Start()
    {
        keypad.SetActive(true);
        _audioSource = chest.GetComponent<AudioSource>();
        opened = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PressedNumber(int number)
    {
        if (number == correctCode[idx])
        {
            ++idx;
            if (idx == 4)
            {
                OpenChest();
                _audioSource.Play();
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

    private void OpenChest()
    {
        if (!opened)
        {
            keypad.SetActive(false);
            chestAnimator.Play("OpenLid", 0, 0.0f);
            opened = true;
        }
    }

}