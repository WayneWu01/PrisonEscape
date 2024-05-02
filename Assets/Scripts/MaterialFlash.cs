using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialFlash : MonoBehaviour
{
    [SerializeField] private Material _material;

    private float lowerLimit = 0f;
    private float upperLimit = 1f;
    private float step;

    private bool increasing = false;
    private bool flashing;

    private float timer;
    private const float time = 0.05f;
    [SerializeField] private int numSteps = 80;

    public bool flashOnStart;

    void Start()
    {
        step = (upperLimit - lowerLimit) / numSteps;

        flashing = flashOnStart;

        if (flashOnStart)
        {
            FlashStart();
        }
    }

    void Update()
    {
        if (flashing)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {

                if (increasing)
                {
                    Color cur = _material.color;
                    _material.color = new Color(cur.r, cur.g, cur.b, cur.a + step);

                    if (_material.color.a >= upperLimit)
                    {
                        increasing = false;
                    }
                }
                else
                {

                    Color cur = _material.color;
                    _material.color = new Color(cur.r, cur.g, cur.b, cur.a - step);

                    if (_material.color.a <= lowerLimit)
                    {
                        increasing = true;
                    }
                }
                timer = time;
            }
        }
    }

    public void FlashStop()
    {
        flashing = false;

        Color cur = _material.color;
        _material.color = new Color(cur.r, cur.g, cur.b, lowerLimit);
    }

    public void FlashStart()
    {
        flashing = true;

        Color cur = _material.color;
        _material.color = new Color(cur.r, cur.g, cur.b, upperLimit - step * 10);
    }
}
