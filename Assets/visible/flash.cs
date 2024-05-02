using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flash : MonoBehaviour
{
    // Start is called before the first frame update
    public bool isOn = false;
    public GameObject lightSource;
    public AudioSource clickSound;
    public bool failSafe = false;

    // Update is called once per frame
    void Update()
    {
		if(Input.GetButtonDown("controller"))
		{
			if(isOn == false && failSafe == false)
			{
				failSafe = true;
				lightSource.SetActive(true);
				clickSound.Play();
				isOn = true;
				StartCoroutine(FailSafe());
			}
			if(isOn == true && failSafe == false)
			{
				failSafe = true;
				lightSource.SetActive(false);
				clickSound.Play();
				isOn = false;
				StartCoroutine(FailSafe());
			}

		}
        
    }
    IEnumerator FailSafe()
    {
		yield return new WaitForSeconds(0.25f);
		failSafe = false;
    }
}
