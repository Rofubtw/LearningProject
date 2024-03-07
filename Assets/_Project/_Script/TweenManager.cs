using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

namespace LearningProject
{
    public class TweenManager : MonoBehaviour
    {
        [SerializeField] Transform box;
        [SerializeField] Transform sylinder;
        //[SerializeField] Ease sylinderEase;

        Tween boxTween;

        void Start()
        {
            boxTween = box.DORotate(new Vector3(180f, 0, 0), 1f).SetLoops(2, LoopType.Incremental)
                .OnPause(() => { sylinder.DOMoveX(5f, 1f); }).OnPlay(() => { sylinder.DOMoveX(0, 1f); });
        }

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                if (boxTween.IsPlaying())
                {
                    boxTween.Pause();
                }
                else
                {
                    boxTween.Restart();
                    boxTween.Play();
                }
            }
        }
    }
}