using GameScene.Managers.Scores;
using GameScene.Managers.Timers;
using UnityEngine;

namespace GameScene.GameItems
{
    public class BullseyeHitDetect : MonoBehaviour
    {
        public CircleCollider2D circleCollider2D;
        public ScriptableScoreManager scriptableScoreManager;
        public ScriptableCountdownTimer scriptableCountdownTimer;
        public AudioSource hitSound;

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
            // Debug.Log("Click");
            scriptableScoreManager.AddScore(5);
            scriptableCountdownTimer.timeValue += 3;
            clickCount++;
            hitSound.pitch = (Random.Range(0.9f, 1.1f));
            hitSound.Play();

            if (clickCount >= 6 || Time.timeScale <= 0)
            {
                circleCollider2D.enabled = false;
            }
        }
    }
}