using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class MovementController : MonoBehaviour
{

    public bool useTeleportation;

    [SerializeField]
    private TeleportationProvider teleporter;

    void Start()
    {
        teleporter.enabled = useTeleportation;

        if (!useTeleportation)
        {
            TeleportationArea[] list = FindObjectsOfType(typeof(TeleportationArea)) as TeleportationArea[];
            foreach (TeleportationArea script in list)
            {
                script.enabled = false;        
            }
        }
    }

}
