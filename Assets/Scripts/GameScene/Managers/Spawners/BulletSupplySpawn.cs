using UnityEngine;

namespace GameScene.Managers.Spawners
{
    public class BulletSupplySpawn : MonoBehaviour
    {
        public GameObject bulletsSupply;

        private float randX;
        private Vector2 whereToSpawn;
        [SerializeField] public float minSpawnRate = 100.0f;
        [SerializeField] public float maxSpawnRate = 300.0f;
        private float nextSpawn;

        private void Update()
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + Random.Range(minSpawnRate, maxSpawnRate);
                randX = Random.Range(-4f, 4f);
                whereToSpawn = new Vector2(randX, transform.position.y);
                Instantiate(bulletsSupply, whereToSpawn, transform.rotation);
            }
        }
    }
}