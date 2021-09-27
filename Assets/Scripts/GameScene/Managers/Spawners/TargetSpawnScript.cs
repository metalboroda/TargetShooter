using UnityEngine;
using Random = UnityEngine.Random;

namespace GameScene.Managers.Spawners
{
    public class TargetSpawnScript : MonoBehaviour
    {
        public GameObject[] target;

        private float randY;
        private Vector2 whereToSpawn;
        [SerializeField] public float minSpawnRate = 5.0f;
        [SerializeField] public float maxSpawnRate = 10.0f;
        private float nextSpawn;

        private void Update()
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + Random.Range(minSpawnRate, maxSpawnRate);
                randY = Random.Range(-2.5f, 2.5f);
                whereToSpawn = new Vector2(transform.position.x, randY);
                Instantiate(target[Random.Range(0, target.Length)], whereToSpawn, transform.rotation);
            }
        }
    }
}