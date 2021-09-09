using System;
using GameScene.Managers;
using UnityEngine;
using UnityEngine.Serialization;

namespace GameScene.GameItems
{
    public class BullseyeHitDetect : MonoBehaviour
    {
        public CircleCollider2D circleCollider2D;
        public ScriptableScoreManager scriptableScoreManager;

        private void Start()
        {
            gameObject.GetComponent<CircleCollider2D>();
        }

        private void OnCollisionEnter2D(Collision2D other)
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
            // FindObjectOfType<ScoreManagerScript>().AddScore();
            // ScoreManagerScript.Instance.AddScore(5);
            scriptableScoreManager.AddScore(5);
            circleCollider2D.enabled = false;
        }
    }
}