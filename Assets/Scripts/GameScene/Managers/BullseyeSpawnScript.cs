using UnityEngine;

namespace GameScene.Managers
{
    public class BullseyeSpawnScript : MonoBehaviour
    {
        public GameObject bullseye;

        public float minSpawnTime = 1.0f;
        public float maxSpawnTime = 3.0f;

        public float spawnRate = 2.0f;
        private float nextSpawn;

        private void Update()
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                Instantiate(bullseye);
            }
        }
    }
}