using System;
using System.Collections;
using System.Collections.Generic;
using GameScene.Managers.Bullets;
using UnityEngine;

public class BulletsDetector : MonoBehaviour
{
    public ScriptableBulletsManagerScript scriptableBulletsManagerScript;

    private void Start()
    {
        scriptableBulletsManagerScript.DecreaseBulletsCount();
    }
}