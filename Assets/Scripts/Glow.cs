using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Glow : MonoBehaviour
{
    private Light _light;

    private float lightLowerLimit = 0.05f;
    private float lightUpperLimit = 0.5f;
    private float lightStep;

    private bool increasing = false;
    private bool glowing;

    private float timer;
    private const float time = 0.05f;
    [SerializeField] private int numSteps = 80;

    public bool glowOnStart;

    void Start()
    {
        lightStep = (lightUpperLimit - lightLowerLimit) / numSteps;
        _light = this.gameObject.GetComponent<Light>();

        glowing = glowOnStart;

        if (glowOnStart)
        {
            GlowStart();
        }
    }

    void Update()
    {
        //if (glowing)
        //{
        //    timer -= Time.deltaTime;
        //    if (timer < 0)
        //    {
        //        if (increasing)
        //        {

        //            _light.intensity = _light.intensity + lightStep;

        //            if (_light.intensity >= lightUpperLimit)
        //            {
        //                increasing = false;
        //            }
        //        }
        //        else
        //        {

        //            _light.intensity = _light.intensity - lightStep;

        //            if (_light.intensity <= lightLowerLimit)
        //            {
        //                increasing = true;
        //            }
        //        }
        //        timer = time;
        //    }
        //}
    }

    public void GlowStop()
    {
        glowing = false;

        _light.intensity = 0;
    }

    public void GlowStart()
    {
        glowing = true;

        _light.intensity = lightUpperLimit - lightStep * 10;
    }
}
