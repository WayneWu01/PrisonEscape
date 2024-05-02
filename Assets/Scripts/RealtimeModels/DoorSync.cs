using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class DoorSync : RealtimeComponent<DoorSyncModel>
{
    private WardenDoor _doorController;

    private void Awake()
    {
        // Get a reference to the mesh renderer
        _doorController = GetComponent<WardenDoor>();
    }

    protected override void OnRealtimeModelReplaced(DoorSyncModel previousModel, DoorSyncModel currentModel)
    {
        if (previousModel != null)
        {
            // Unregister from events
            previousModel.openDidChange -= OpenDidChange;
        }

        if (currentModel != null)
        {
            // If this is a model that has no data set on it, populate it with the current mesh renderer color.
            if (currentModel.isFreshModel)
                currentModel.open = _doorController.opened;

            // Update the mesh render to match the new model
            UpdateDoorState();

            // Register for events so we'll know if the color changes later
            currentModel.openDidChange += OpenDidChange;
        }
    }

    private void OpenDidChange(DoorSyncModel model, bool value)
    {
        // Update the mesh renderer
        UpdateDoorState();
    }

    private void UpdateDoorState()
    {
        // Get the color from the model and set it on the mesh renderer.
        if (!_doorController.opened && model.open)
        {
            _doorController.openDoor();
            _doorController.opened = model.open;
        }
    }

    public void SetOpened(bool opened)
    {
        // Set the color on the model
        // This will fire the colorChanged event on the model, which will update the renderer for both the local player and all remote players.
        model.open = opened;
    }
}