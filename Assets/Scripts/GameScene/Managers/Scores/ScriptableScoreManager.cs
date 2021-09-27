using UnityEngine;

namespace GameScene.Managers.Scores
{
    [CreateAssetMenu(menuName = "ScoreManager")]
    public class ScriptableScoreManager : ScriptableObject
    {
        [HideInInspector] public int score;

        private void OnEnable()
        {
            score = 0;
        }

        public void AddScore(int amount)
        {
            score += amount;

            if (score % 10 == 0)
            {
                // Debug.Log("You have 100");
                DifficultyManagerScript.Instance.AddAnimationsAndSpawnSpeed();
            }
        }
    }
}