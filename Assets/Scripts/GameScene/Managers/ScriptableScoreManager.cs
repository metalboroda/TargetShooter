using UnityEngine;

namespace GameScene.Managers
{
    [CreateAssetMenu(menuName = "ScoreManager")]
    public class ScriptableScoreManager : ScriptableObject
    {
        [HideInInspector]
        public int score;

        private void OnEnable()
        {
            score = 0;
        }

        public void AddScore(int amount)
        {
            score += amount;
        }
    }
}