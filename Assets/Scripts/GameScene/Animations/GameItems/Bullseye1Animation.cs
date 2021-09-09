using DG.Tweening;
using UnityEngine;

namespace GameScene.Animations.GameItems
{
    public class Bullseye1Animation : MonoBehaviour
    {
        [SerializeField] private float endPoint = 0.86f;
        [SerializeField] private float startPoint = -1.13f;

        [SerializeField] private float durationMin = 0.1f;
        [SerializeField] private float durationMax = 0.3f;
        [SerializeField] private float delayInMin = 1;
        [SerializeField] private float delayInMax = 3;
        [SerializeField] private float delayOutMin = 3;
        [SerializeField] private float delayOutMax = 5;

        private void Start()
        {
            BullseyeAnimationSequencesY();
        }

        private void BullseyeAnimationSequencesY()
        {
            var inBullseyeSequence = DOTween.Sequence();
            inBullseyeSequence
                .Append(transform.DOLocalMoveY(endPoint, Random.Range(durationMin, durationMax)))
                .SetDelay(Random.Range(delayInMin, delayInMax));

            var outBullseyeSequence = DOTween.Sequence();
            outBullseyeSequence
                .Insert(0, transform.DOLocalMoveY(startPoint, Random.Range(durationMin, durationMax)))
                .SetDelay(Random.Range(delayOutMin, delayOutMax))
                .OnComplete(() => Destroy(gameObject));
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