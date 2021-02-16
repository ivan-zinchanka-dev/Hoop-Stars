using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Loader : MonoBehaviour
{
    [SerializeField] private Slider _loadingSlider;

    public void Awake()
    {
        StartCoroutine(LoadSceneAsync(1));
    }

    private IEnumerator LoadSceneAsync(int sceneIndex) {

        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);
        float progress;

        while (!operation.isDone) {

            progress = Mathf.Clamp01(operation.progress / .9f);
            _loadingSlider.value = progress;

            yield return null;
        }
    
    }


}
