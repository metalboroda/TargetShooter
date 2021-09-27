using GameScene.Managers.Bullets;
using GameScene.Managers.Scores;
using GameScene.Managers.Timers;
using UnityEngine;

namespace GameScene.Managers.GameProcesses
{
    public class GameOverScript : MonoBehaviour
    {
        // GameObjects
        public ScriptableBulletsManagerScript scriptableBulletsManagerScript;
        public ScriptableCountdownTimer scriptableCountdownTimer;
        public ScriptableScoreManager scriptableScoreManager;
        public GameObject shooting;
        public GameObject spawnPoint1;
        public GameObject spawnPoint2;
        public GameObject spawnPoint3;
        public GameObject gameOverScreen;
        public AudioSource gameMusic;

        // Scripts
        public CountdownTimer countdownTimer;

        private void Update()
        {
            if (countdownTimer.scriptableCountdownTimer.timeValue <= 0 ||
                scriptableBulletsManagerScript.bulletsCount <= 0)
            {
                scriptableCountdownTimer.timeValue = 0;
                shooting.SetActive(false);
                spawnPoint1.SetActive(false);
                spawnPoint2.SetActive(false);
                spawnPoint3.SetActive(false);
                gameOverScreen.SetActive(true);
                gameMusic.Stop();

                // PlayerPrefs.SetInt("Score", scriptableScoreManager.score);
            }
        }
    }
}