using UnityEngine;

namespace GameScene.Managers.Bullets
{
    [CreateAssetMenu(fileName = "Bullets Manager")]
    public class ScriptableBulletsManagerScript : ScriptableObject
    {
        [HideInInspector] public int bulletsCount = 90;

        private void OnEnable()
        {
            bulletsCount = 90;
        }

        public void DecreaseBulletsCount()
        {
            bulletsCount--;
        }
    }
}