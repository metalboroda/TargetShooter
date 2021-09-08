using UnityEngine;
using UnityEngine.UI;

namespace GameScene.Managers
{
    public class ScoreManagerScript : MonoBehaviour
    {
        public Text scoreCountText;

        private int scoreCount;

        public void AddScore()
        {
            scoreCount += 10;

            scoreCountText.text = scoreCount.ToString();
        }
    }
}