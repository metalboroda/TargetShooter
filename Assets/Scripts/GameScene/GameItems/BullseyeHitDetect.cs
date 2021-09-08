using System;
using GameScene.Managers;
using UnityEngine;
using UnityEngine.UI;

namespace GameScene.GameItems
{
    public class BullseyeHitDetect : MonoBehaviour
    {
        public ScoreManagerScript scoreManagerScript;
        
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
            // Call methods
            scoreManagerScript.AddScore();
        }
    }
}