using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadingSceneContoller : Singalton<LoadingSceneContoller>
{
    [SerializeField] private GameObject _loadingScreenObject;
    
    public void LoadNextScene(string sceneName)
    {
        StartCoroutine(LoadSceneCoroutine(sceneName));
    }
    private IEnumerator LoadSceneCoroutine(string sceneName)
    {
   
        _loadingScreenObject.SetActive(true);
        
        AsyncOperation unloadOp = SceneManager.UnloadSceneAsync(SceneManager.GetActiveScene());

        while (!unloadOp.isDone)
        {
            Debug.Log("upload is not done");
            yield return new  WaitForSeconds(2f);
        }

        
        AsyncOperation loadOp = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);
        loadOp.allowSceneActivation = true;
        while (!loadOp.isDone)
        {
            Debug.Log("load is not done");
            yield return new  WaitForSeconds(2f);
        }
        
        
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(sceneName));
        _loadingScreenObject.SetActive(false);
    }
}
