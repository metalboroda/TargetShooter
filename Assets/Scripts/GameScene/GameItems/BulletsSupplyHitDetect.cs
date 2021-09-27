using GameScene.Managers.Bullets;
using UnityEngine;

namespace GameScene.GameItems
{
    public class BulletsSupplyHitDetect : MonoBehaviour
    {
        public CircleCollider2D circleCollider2D;
        public ScriptableBulletsManagerScript scriptableBulletsManagerScript;
        // public AudioSource hitSound;

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
            scriptableBulletsManagerScript.bulletsCount += 4;
            clickCount++;
            // hitSound.pitch = (Random.Range(0.9f, 1.1f));
            // hitSound.Play();
            // Debug.Log("Bullets");
            if (clickCount >= 6 || Time.timeScale <= 0)
            {
                circleCollider2D.enabled = false;
            }
        }
    }
}