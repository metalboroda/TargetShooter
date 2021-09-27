using System;
using System.Collections;
using System.Collections.Generic;
using GameScene.Managers;
using GameScene.Managers.Spawners;
using UnityEngine;

public class DifficultyManagerScript : MonoBehaviour
{
    public SpawnAnimationsControllerScript spawnAnimationsControllerScript;
    public static DifficultyManagerScript Instance { get; private set; }

    public BullseyeSpawnScript BullseyeSpawnScript;
    public TargetSpawnScript TargetSpawnScript1;
    public TargetSpawnScript TargetSpawnScript2;

    private float reduceAnimationsValue = 0.01f;
    private float reduceSpawnValue = 0.02f;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddAnimationsAndSpawnSpeed()
    {
        // Animations speed
        if (spawnAnimationsControllerScript.durationMin <= 0.01f)
        {
            spawnAnimationsControllerScript.durationMin = 0.01f;
        }
        else
        {
            spawnAnimationsControllerScript.durationMin -= reduceAnimationsValue;
        }

        if (spawnAnimationsControllerScript.durationMax <= 0.03f)
        {
            spawnAnimationsControllerScript.durationMax = 0.03f;
        }
        else
        {
            spawnAnimationsControllerScript.durationMax -= reduceAnimationsValue;
        }

        if (spawnAnimationsControllerScript.delayInMin <= 0.01f)
        {
            spawnAnimationsControllerScript.delayInMin = 0.01f;
        }
        else
        {
            spawnAnimationsControllerScript.delayInMin -= reduceAnimationsValue;
        }

        if (spawnAnimationsControllerScript.delayInMax <= 0.03f)
        {
            spawnAnimationsControllerScript.delayInMax = 0.03f;
        }
        else
        {
            spawnAnimationsControllerScript.delayInMax -= reduceAnimationsValue;
        }

        if (spawnAnimationsControllerScript.delayOutMin <= 0.03f)
        {
            spawnAnimationsControllerScript.delayOutMin = 0.03f;
        }
        else
        {
            spawnAnimationsControllerScript.delayOutMin -= reduceAnimationsValue;
        }

        if (spawnAnimationsControllerScript.delayOutMax <= 0.05f)
        {
            spawnAnimationsControllerScript.delayOutMax = 0.05f;
        }
        else
        {
            spawnAnimationsControllerScript.delayOutMax -= reduceAnimationsValue;
        }

        // Debug.Log(SpawnAnimationsControllerScript.durationMin);
        // Debug.Log(SpawnAnimationsControllerScript.durationMax);
        // Debug.Log(SpawnAnimationsControllerScript.delayInMin);
        // Debug.Log(SpawnAnimationsControllerScript.delayInMax);
        // Debug.Log(SpawnAnimationsControllerScript.delayOutMin);
        // Debug.Log(SpawnAnimationsControllerScript.delayOutMax);

        // Spawn speed
        if (BullseyeSpawnScript.minSpawnTime <= 0.05f)
        {
            BullseyeSpawnScript.minSpawnTime = 0.05f;
        }
        else
        {
            BullseyeSpawnScript.minSpawnTime -= reduceSpawnValue;
        }

        if (BullseyeSpawnScript.maxSpawnTime <= 0.05f)
        {
            BullseyeSpawnScript.maxSpawnTime = 0.05f;
        }
        else
        {
            BullseyeSpawnScript.maxSpawnTime -= reduceSpawnValue;
        }

        if (TargetSpawnScript1.minSpawnRate <= 0.05f)
        {
            TargetSpawnScript1.minSpawnRate = 0.05f;
        }
        else
        {
            TargetSpawnScript1.minSpawnRate -= reduceSpawnValue;
        }

        if (TargetSpawnScript1.maxSpawnRate <= 0.05f)
        {
            TargetSpawnScript1.maxSpawnRate = 0.05f;
        }
        else
        {
            TargetSpawnScript1.maxSpawnRate -= reduceSpawnValue;
        }

        if (TargetSpawnScript2.minSpawnRate <= 0.05f)
        {
            TargetSpawnScript2.minSpawnRate = 0.05f;
        }
        else
        {
            TargetSpawnScript2.minSpawnRate -= reduceSpawnValue;
        }

        if (TargetSpawnScript2.maxSpawnRate <= 0.05f)
        {
            TargetSpawnScript2.maxSpawnRate = 0.05f;
        }
        else
        {
            TargetSpawnScript2.maxSpawnRate -= reduceSpawnValue;
        }
    }
}