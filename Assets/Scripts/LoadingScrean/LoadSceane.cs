using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadSceane : MonoBehaviour
{
    public Slider slider;
    bool playDone = false;
    void Start()
    {
       
    }

    void Update() {
        Debug.Log(playDone);
        if (playDone == true) {
            StartCoroutine(LoadSceneAsync(1));
        }
    }
    IEnumerator LoadSceneAsync(int sceneIndex) {
        yield return new WaitForSeconds(2f);
        slider.value += 0.4f;
        if (slider.value >= 1) {
            SceneManager.LoadScene("SampleScene");
        }
        //AsyncOperation operation = SceneManager.LoadSceneAsync(sceneIndex);

        //while (!operation.isDone)
        //{

        //    Debug.Log(operation.progress);
        //    yield return null;
        //}
    }

    public void PlayButtonClick() {
        playDone = true;
        slider.gameObject.SetActive(true);
        
    }
}
