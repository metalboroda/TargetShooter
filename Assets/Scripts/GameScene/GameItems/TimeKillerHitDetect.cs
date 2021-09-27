using GameScene.Managers.Bullets;
using GameScene.Managers.Timers;
using UnityEngine;

namespace GameScene.GameItems
{
    public class TimeKillerHitDetect : MonoBehaviour
    {
        public CircleCollider2D circleCollider2D;

        public ScriptableCountdownTimer scriptableCountdownTimer;
        public AudioSource timeKillerHitSound;

        private int clickCount;

        private void OnCollisionEnter2D()
        {
            OnMouseDown();
        }

        private void OnMouseDown()
        {
            if (!Input.GetMouseButtonDown(0)) return;
            if (Camera.main is null) return;
            var mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            var mousePos2D = new Vector2(mousePos.x, mousePos.y);

            var hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if (hit.collider == null) return;
            scriptableCountdownTimer.timeValue -= 10;
            clickCount++;
            timeKillerHitSound.pitch = (Random.Range(0.9f, 1.1f));
            timeKillerHitSound.Play();
            if (clickCount >= 6 || Time.timeScale <= 0)
            {
                circleCollider2D.enabled = false;
            }
        }
    }
}