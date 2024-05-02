using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ReticleColor : MonoBehaviour
{
    private GameManager _gameManager;

    // link colors to the materials
    [System.Serializable]
    public struct ColorSetting
    {
        public GameManager.Colors _color;
        public Material _material;
        public Gradient _gradient;
    }
    public ColorSetting[] colors;

    // get line visual
    [SerializeField] private XRInteractorLineVisual lineVisual;
    [SerializeField] private Material reticleMaterial;
    
    private void Start()
    {
        _gameManager = FindObjectOfType<GameManager>();

        lineVisual = GetComponentInChildren<XRInteractorLineVisual>();
        reticleMaterial = lineVisual.reticle.GetComponent<Material>();
    }

    private void Update()
    {
        ColorSetting selection = colors[(int)_gameManager.colorChoice];

        reticleMaterial = selection._material;
        lineVisual.validColorGradient = selection._gradient;
    }
}
