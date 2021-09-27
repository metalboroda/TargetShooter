using UnityEngine;

namespace Settings
{
    public class FrameRate : MonoBehaviour
    {
        private void Awake()
        {
            Application.targetFrameRate = 45;
            Input.multiTouchEnabled = false;
        }
    }
}