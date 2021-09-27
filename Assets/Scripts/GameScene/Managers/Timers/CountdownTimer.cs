using System;
using UnityEngine;
using UnityEngine.UI;

namespace GameScene.Managers.Timers
{
    public class CountdownTimer : MonoBehaviour
    {
        public ScriptableCountdownTimer scriptableCountdownTimer;

        public Text timeText;

        private void Start()
        {
            scriptableCountdownTimer.timeValue = 60;
        }

        private void Update()
        {
            if (scriptableCountdownTimer.timeValue > 0)
            {
                scriptableCountdownTimer.timeValue -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has passed!");
            }

            DisplayTime(scriptableCountdownTimer.timeValue);
        }

        private void DisplayTime(float timeToDisplay)
        {
            if (timeToDisplay < 0)
            {
                timeToDisplay = 0;
            }

            float minutes = Mathf.FloorToInt(timeToDisplay / 60);
            float seconds = Mathf.FloorToInt(timeToDisplay % 60);

            timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }
    }
}