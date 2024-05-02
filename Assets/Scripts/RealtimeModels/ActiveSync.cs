using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using TMPro;

public class ActiveSync : RealtimeComponent<ActiveSyncModel>
{
    [SerializeField] private GameObject _object;

    private void Awake()
    {
        // Get a reference to the mesh renderer
        // _text = GetComponent<TextMeshPro>();
    }

    protected override void OnRealtimeModelReplaced(ActiveSyncModel previousModel, ActiveSyncModel currentModel)
    {
        if (previousModel != null)
        {
            // Unregister from events
            previousModel.activeDidChange -= ActiveDidChange;
        }

        if (currentModel != null)
        {
            // If this is a model that has no data set on it, populate it with the current active value.
            if (currentModel.isFreshModel)
                currentModel.active = _object.activeInHierarchy;

            // Update the active property to match the new model
            UpdateActive();

            // Register for events so we'll know if the color changes later
            currentModel.activeDidChange += ActiveDidChange;
        }
    }

    private void ActiveDidChange(ActiveSyncModel model, bool value)
    {
        // Update the active property
        UpdateActive();
    }

    private void UpdateActive()
    {
        _object.SetActive(model.active);
    }

    public void SetActive(bool active)
    {
        model.active = active;
    }

}