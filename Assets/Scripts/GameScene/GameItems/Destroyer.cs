using UnityEngine;

namespace GameScene.GameItems
{
    public class Destroyer : MonoBehaviour
    {
        [SerializeField] private float timeToDestroy = 7.0f;

        void Update()
        {
            Destroy(gameObject, timeToDestroy);
        }
    }
}