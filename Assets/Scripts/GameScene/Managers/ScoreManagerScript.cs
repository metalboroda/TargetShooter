using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameScene.Managers
{
    public class ScoreManagerScript : MonoBehaviour
    {
        // Singleton
        public static ScoreManagerScript Instance { get; private set; }

        public Text scoreCountText;

        private int scoreCount;

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

        public void AddScore(int score)
        {
            scoreCount += score;

            scoreCountText.text = scoreCount.ToString();
        }
    }
}