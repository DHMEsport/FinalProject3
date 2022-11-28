using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GoingNextScene : MonoBehaviour
{
    [SerializeField] private string _nextSceneName;

    private FadeAnimation animationfade;

    private IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
            SceneManager.LoadScene(_nextSceneName);
            yield return StartCoroutine(animationfade.FadeToBlack());
            Debug.Log("the scene is now loading");
        }
    }
}
