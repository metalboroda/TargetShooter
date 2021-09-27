using UnityEngine;

namespace GameScene.UI
{
    public class PauseButtonScript : MonoBehaviour
    {
        public void PauseGameMethod()
        {
            Time.timeScale = 0;
        }

        public void ResumeGameMethod()
        {
            Time.timeScale = 1;
        }
    }
}