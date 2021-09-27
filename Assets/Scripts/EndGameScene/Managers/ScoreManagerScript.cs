using System;
using GameScene.Managers.Scores;
using UnityEngine;
using UnityEngine.UI;

namespace EndGameScene.Scores
{
    public class ScoreManagerScript : MonoBehaviour
    {
        public ScriptableScoreManager scriptableScoreManager;

        public Text scoreText;
        public Text highScoreText;

        private int highScoreValue;

        private void Start()
        {
            scoreText.text = scriptableScoreManager.score.ToString();

            if (scriptableScoreManager.score > PlayerPrefs.GetInt("HighScore", 0))
            {
                PlayerPrefs.SetInt("HighScore", scriptableScoreManager.score);
                highScoreText.text = scriptableScoreManager.score.ToString();
            }
            else
            {
                highScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
            }
        }
    }
}