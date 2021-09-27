using UnityEngine;
using UnityEngine.Audio;

namespace EndGameScene.Managers
{
    public class EndGameAudioManagerScript : MonoBehaviour
    {
        public AudioMixerGroup musicChannel;

        private void Start()
        {
            MusicChecker();
        }

        private void MusicChecker()
        {
            if (PlayerPrefs.GetInt("MusicChannel") == 1)
            {
                MusicOnMethod();
            }
            else
            {
                MusicOffMethod();
            }
        }

        private void MusicOnMethod()
        {
            musicChannel.audioMixer.SetFloat("MusicChannel", -5.0f);
            PlayerPrefs.SetInt("MusicChannel", 1);
        }

        private void MusicOffMethod()
        {
            musicChannel.audioMixer.SetFloat("MusicChannel", -80.0f);
            PlayerPrefs.SetInt("MusicChannel", 0);
        }
    }
}