using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameScene.Managers
{
    public class BullseyeSpawnScript : MonoBehaviour
    {
        public GameObject bullseye;

        public float minSpawnTime = 6.0f;
        public float maxSpawnTime = 7.0f;

        // public float spawnRate = 7.0f;
        private float nextSpawn;

        private void Update()
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + Random.Range(minSpawnTime, maxSpawnTime);
                Instantiate(bullseye);
            }
        }
    }
}