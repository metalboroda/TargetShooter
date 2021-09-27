using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

namespace MainMenuScene.Managers
{
    public class AudioManagerScript : MonoBehaviour
    {
        // Music vars
        public AudioMixerGroup musicChannel;
        private bool isMusicOn;
        public Image musicImage;
        public Sprite musicOn;
        public Sprite musicOff;

        // SFX vars
        public AudioMixerGroup sfxChannel;
        private bool isSfxOn;
        public Image sfxImage;
        public Sprite sfxOn;
        public Sprite sfxOff;

        private void Start()
        {
            MusicChecker();
            SfxChecker();
        }

        #region Music

        public void MusicSwitcher()
        {
            if (isMusicOn == false)
            {
                MusicOnMethod();
            }
            else
            {
                MusicOffMethod();
            }
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
            isMusicOn = true;
            musicChannel.audioMixer.SetFloat("MusicChannel", -10.0f);
            musicImage.sprite = musicOn;
            PlayerPrefs.SetInt("MusicChannel", 1);
        }

        private void MusicOffMethod()
        {
            isMusicOn = false;
            musicChannel.audioMixer.SetFloat("MusicChannel", -80.0f);
            musicImage.sprite = musicOff;
            PlayerPrefs.SetInt("MusicChannel", 0);
        }

        #endregion

        #region SFX

        public void SFXSwitcher()
        {
            if (isSfxOn == false)
            {
                SfxOnMethod();
            }
            else
            {
                SfxOffMethod();
            }
        }

        private void SfxChecker()
        {
            if (PlayerPrefs.GetInt("SFXChannel") == 1)
            {
                SfxOnMethod();
            }
            else
            {
                SfxOffMethod();
            }
        }

        private void SfxOnMethod()
        {
            isSfxOn = true;
            sfxChannel.audioMixer.SetFloat("SFXChannel", 0.0f);
            sfxImage.sprite = sfxOn;
            PlayerPrefs.SetInt("SFXChannel", 1);
        }

        private void SfxOffMethod()
        {
            isSfxOn = false;
            sfxChannel.audioMixer.SetFloat("SFXChannel", -80.0f);
            sfxImage.sprite = sfxOff;
            PlayerPrefs.SetInt("SFXChannel", 0);
        }

        #endregion
    }
}