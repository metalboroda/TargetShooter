using DG.Tweening;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameScene.Animations.GameItems
{
    public class BullseyeAnimationX : MonoBehaviour
    {
        public SpawnAnimationsControllerScript spawnAnimationsControllerScript;
        
        [SerializeField] private float endPoint = -7.0f;
        [SerializeField] private float startPoint = -12.0f;

        // [SerializeField] private float durationMin = 0.1f;
        // [SerializeField] private float durationMax = 0.3f;
        // [SerializeField] private float delayInMin = 1.0f;
        // [SerializeField] private float delayInMax = 3.0f;
        // [SerializeField] private float delayOutMin = 3.0f;
        // [SerializeField] private float delayOutMax = 5.0f;

        private void Start()
        {
            BullseyeAnimationSequencesX();
        }

        private void BullseyeAnimationSequencesX()
        {
            var inBullseyeSequence = DOTween.Sequence();
            inBullseyeSequence
                .Append(transform.DOLocalMoveX(endPoint,
                    Random.Range(spawnAnimationsControllerScript.durationMin,
                        spawnAnimationsControllerScript.durationMax)))
                .SetDelay(Random.Range(spawnAnimationsControllerScript.delayInMin,
                    spawnAnimationsControllerScript.delayInMax));

            var outBullseyeSequence = DOTween.Sequence();
            outBullseyeSequence
                .Insert(0,
                    transform.DOLocalMoveX(startPoint,
                        Random.Range(spawnAnimationsControllerScript.durationMin,
                            spawnAnimationsControllerScript.durationMax)))
                .SetDelay(Random.Range(spawnAnimationsControllerScript.delayOutMin,
                    spawnAnimationsControllerScript.delayOutMax))
                .OnComplete(() => Destroy(gameObject));
        }
    }
}