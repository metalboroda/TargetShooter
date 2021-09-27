using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "SpawnAnimationsControllerScript")]
public class SpawnAnimationsControllerScript : ScriptableObject
{
    public float durationMin = 0.1f;
    public float durationMax = 0.3f;
    public float delayInMin = 1.0f;
    public float delayInMax = 3.0f;
    public float delayOutMin = 3.0f;
    public float delayOutMax = 5.0f;

    private void OnEnable()
    {
        durationMin = 0.1f;
        durationMax = 0.3f;
        delayInMin = 1.0f;
        delayInMax = 3.0f;
        delayOutMin = 3.0f;
        delayOutMax = 5.0f;
    }
}