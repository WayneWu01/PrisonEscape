using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Normal.Realtime;
using TMPro;

public class FlushTextSync : RealtimeComponent<FlushTextSyncModel>
{
    [SerializeField] private TextMeshPro _text;

    private void Awake()
    {
        // Get a reference to the mesh renderer
        // _text = GetComponent<TextMeshPro>();
    }

    protected override void OnRealtimeModelReplaced(FlushTextSyncModel previousModel, FlushTextSyncModel currentModel)
    {
        if (previousModel != null)
        {
            // Unregister from events
            previousModel.textDidChange -= TextDidChange;
        }

        if (currentModel != null)
        {
            // If this is a model that has no data set on it, populate it with the current mesh renderer color.
            if (currentModel.isFreshModel)
                currentModel.text = _text.text;

            // Update the mesh render to match the new model
            UpdateFlushText();

            // Register for events so we'll know if the color changes later
            currentModel.textDidChange += TextDidChange;
        }
    }

    private void TextDidChange(FlushTextSyncModel model, string value)
    {
        // Update the mesh renderer
        UpdateFlushText();
    }

    private void UpdateFlushText()
    {
        // Get the color from the model and set it on the mesh renderer.
        _text.text = model.text;
    }

    public void SetText(string text)
    {
        // Set the color on the model
        // This will fire the colorChanged event on the model, which will update the renderer for both the local player and all remote players.
        model.text = text;
    }
}