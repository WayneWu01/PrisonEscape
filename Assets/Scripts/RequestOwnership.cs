using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using UnityEngine.XR.Interaction.Toolkit;

public class RequestOwnership : MonoBehaviour
{
    private RealtimeView realtimeView;
    private RealtimeTransform realtimeTransform;
    private XRGrabInteractable grabInteractable;

    private void Start()
    {
        realtimeView = this.gameObject.GetComponent<RealtimeView>();
        realtimeTransform = this.gameObject.GetComponent<RealtimeTransform>();
        grabInteractable = this.gameObject.GetComponent<XRGrabInteractable>();
    }

    private void Update()
    {
        if (grabInteractable.isSelected)
        {
            realtimeTransform.RequestOwnership();
            realtimeView.RequestOwnership();
        }
    }

    //private void OnEnable()
    //{
    //    grabInteractable.selectEntered.AddListener(RequestObjectOwnership);
    //}

    //private void OnDisable()
    //{
    //    grabInteractable.selectEntered.RemoveListener(RequestObjectOwnership);
    //}

    //private void RequestObjectOwnership(SelectEnterEventArgs args)
    //{
    //    realtimeView.RequestOwnership();
    //    realtimeTransform.RequestOwnership();
    //}
}
