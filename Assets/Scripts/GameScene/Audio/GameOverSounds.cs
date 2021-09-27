using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameScene.Audio
{
    public class GameOverSounds : MonoBehaviour
    {
        public AudioSource letterSound;

        public void PlayLetterSound()
        {
            letterSound.pitch = (Random.Range(0.9f, 1.1f));
            letterSound.Play();
        }
    }
}