using DG.Tweening;
using UnityEngine;

namespace GameScene.Animations.GameItems
{
    public class Bullseye2Animation : MonoBehaviour
    {
        [SerializeField] private float endPoint = 0.86f;
        [SerializeField] private float startPoint = -1.13f;

        [SerializeField] private float durationMin;
        [SerializeField] private float durationMax;
        [SerializeField] private float delayInMin;
        [SerializeField] private float delayInMax;
        [SerializeField] private float delayOutMin;
        [SerializeField] private float delayOutMax;

        private void Start()
        {
            BullseyeAnimationSequencesX();
        }

        private void BullseyeAnimationSequencesX()
        {
            var inBullseyeSequence = DOTween.Sequence();
            inBullseyeSequence
                .Append(transform.DOLocalMoveX(endPoint, Random.Range(durationMin, durationMax)))
                .SetDelay(Random.Range(delayInMin, delayInMax));

            var outBullseyeSequence = DOTween.Sequence();
            outBullseyeSequence
                .Insert(0, transform.DOLocalMoveX(startPoint, Random.Range(durationMin, durationMax)))
                .SetDelay(Random.Range(delayOutMin, delayOutMax))
                .OnComplete(() => Destroy(gameObject));
        }
    }
}