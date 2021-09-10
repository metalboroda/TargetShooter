using UnityEngine;
using Random = UnityEngine.Random;

namespace GameScene.Managers
{
    public class TargetSpawnScript : MonoBehaviour
    {
        public GameObject target;

        private float randY;
        private Vector2 whereToSpawn;
        [SerializeField] private float minSpawnRate = 5.0f;
        [SerializeField] private float maxSpawnRate = 10.0f;
        private float nextSpawn;

        private void Update()
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + Random.Range(minSpawnRate, maxSpawnRate);
                randY = Random.Range(-2.5f, 3.0f);
                whereToSpawn = new Vector2(transform.position.x, randY);
                Instantiate(target, whereToSpawn, Quaternion.identity);
            }
        }
    }
}