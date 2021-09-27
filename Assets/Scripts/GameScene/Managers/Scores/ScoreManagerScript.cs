using UnityEngine;
using UnityEngine.UI;

namespace GameScene.Managers.Scores
{
    public class ScoreManagerScript : MonoBehaviour
    {
        // Singleton
        public static ScoreManagerScript Instance { get; private set; }

        public Text scoreCountText;

        [HideInInspector] public int scoreCount;

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

        private void Start()
        {
            scoreCount = 0;
        }

        public void AddScore(int score)
        {
            scoreCount += score;

            scoreCountText.text = scoreCount.ToString();
        }
    }
}