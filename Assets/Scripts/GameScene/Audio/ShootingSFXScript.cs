using UnityEngine;

namespace GameScene.Audio
{
    public class ShootingSFXScript : MonoBehaviour
    {
        public AudioSource shoot;
        public AudioSource shell;

        private void Start()
        {
            shoot.pitch = (Random.Range(0.95f, 1.05f));
            shell.pitch = (Random.Range(0.95f, 1.05f));
            shoot.Play();
            shell.Play();
        }
    }
}