using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class FadeAnimation : MonoBehaviour
    {
        private Animator _animator;
        private bool isFading = false;

        private void Start()
        {
            _animator = GetComponent<Animator>();
            
        }

        public IEnumerator FadeClean()
        {
            isFading = true;
            // _animator.SetTrigger("FadeIn");
            _animator.SetTrigger("FadeIn2");
            while (isFading)
            {
                Debug.Log("Now is Fading go to next the scene");
            }
            
            yield return null;
        }

         public  IEnumerator FadeToBlack()
        {
            isFading = true;
            _animator.SetTrigger("FadeOut");
            while (isFading)
            {
                Debug.Log("Now Fading is finish to progress");
            }
            yield return null;
        }

        void AnimationComplete()
        {
            isFading = false;
        }
    }
