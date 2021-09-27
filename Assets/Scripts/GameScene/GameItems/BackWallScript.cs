using UnityEngine;
using Random = UnityEngine.Random;

namespace GameScene.GameItems
{
    public class BackWallScript : MonoBehaviour
    {
        public BoxCollider2D boxCollider2D;
        public AudioSource wallSound;

        private void Start()
        {
            gameObject.GetComponent<BoxCollider2D>();
        }

        private void OnTriggerEnter2D(Collider2D other)
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
            // Debug.Log("Wall");
            wallSound.pitch = (Random.Range(0.9f, 1.1f));
            wallSound.Play();
        }
    }
}