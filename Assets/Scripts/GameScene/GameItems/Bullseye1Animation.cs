using DG.Tweening;
using UnityEngine;

namespace GameScene.GameItems
{
    public class Bullseye1Animation : MonoBehaviour
    {
        public float endPoint = 0.86f;
        public float startPoint = -1.13f;

        public float durationMin;
        public float durationMax;
        public float delaInMin;
        public float delaInMax;
        public float delayOutMin;
        public float delayOutMax;

        private void Start()
        {
            BullseyeAnimationSequences();
        }

        private void BullseyeAnimationSequences()
        {
            var inBullseyeSequence = DOTween.Sequence();
            inBullseyeSequence
                .Append(transform.DOLocalMoveY(endPoint, Random.Range(durationMin, durationMax)))
                .SetDelay(Random.Range(delaInMin, delaInMax));

            var outBullseyeSequence = DOTween.Sequence();
            outBullseyeSequence
                .Insert(0, transform.DOLocalMoveY(startPoint, Random.Range(durationMin, durationMax)))
                .SetDelay(Random.Range(delayOutMin, delayOutMax))
                .OnComplete(() => Destroy(gameObject));
        }
    }
}