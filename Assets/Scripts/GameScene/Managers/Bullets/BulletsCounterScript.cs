using System;
using System.Collections;
using System.Collections.Generic;
using GameScene.Managers.Bullets;
using UnityEngine;
using UnityEngine.UI;

public class BulletsCounterScript : MonoBehaviour
{
    public ScriptableBulletsManagerScript scriptableBulletsManagerScript;

    public Text bulletCountText;

    private void Update()
    {
        bulletCountText.text = scriptableBulletsManagerScript.bulletsCount.ToString();
    }
}