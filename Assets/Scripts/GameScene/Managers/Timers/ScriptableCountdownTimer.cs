using System;
using UnityEngine;

namespace GameScene.Managers.Timers
{
    [CreateAssetMenu(fileName = "Countdown Manager")]
    public class ScriptableCountdownTimer : ScriptableObject
    {
        [SerializeField] public float timeValue = 60;

        private void OnEnable()
        {
            timeValue = 60;
        }
    }
}