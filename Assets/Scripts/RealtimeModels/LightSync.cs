using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;

public class LightSync : RealtimeComponent<LightSyncModel>
{
    private Light _light;

    private void Awake()
    {
        // Get a reference to the mesh renderer
        _light = GetComponent<Light>();
    }

    protected override void OnRealtimeModelReplaced(LightSyncModel previousModel, LightSyncModel currentModel)
    {
        if (previousModel != null)
        {
            // Unregister from events
            previousModel.litDidChange -= LitDidChange;
            previousModel.colorDidChange -= ColorDidChange;
        }

        if (currentModel != null)
        {
            // If this is a model that has no data set on it, populate it with the current mesh renderer color.
            if (currentModel.isFreshModel)
            {
                currentModel.lit = _light.enabled;
                currentModel.color = _light.color;
            }

            // Update the mesh render to match the new model
            UpdateLightEnabled();
            UpdateLightColor();

            // Register for events so we'll know if the color changes later
            currentModel.litDidChange += LitDidChange;
            currentModel.colorDidChange += ColorDidChange;
        }
    }

    // LIGHT UPDATES

    private void LitDidChange(LightSyncModel model, bool value)
    {
        // Update the mesh renderer
        UpdateLightEnabled();
    }

    private void UpdateLightEnabled()
    {
        // Get the color from the model and set it on the mesh renderer.
        _light.enabled = model.lit;
    }

    public void SetLight(bool enabled)
    {
        // Set the color on the model
        // This will fire the colorChanged event on the model, which will update the renderer for both the local player and all remote players.
        model.lit = enabled;
    }

    // COLOR UPDATES

    private void ColorDidChange(LightSyncModel model, Color value)
    {
        // Update the mesh renderer
        UpdateLightColor();
    }

    private void UpdateLightColor()
    {
        // Get the color from the model and set it on the mesh renderer.
        _light.color = model.color;
    }

    public void SetColor(Color color)
    {
        // Set the color on the model
        // This will fire the colorChanged event on the model, which will update the renderer for both the local player and all remote players.
        model.color = color;
    }
}