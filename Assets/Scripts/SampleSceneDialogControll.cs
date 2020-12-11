using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SampleSceneDialogControll : MonoBehaviour
{
    public GameObject[] dialogBoxs;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ShowFirstDialog() {
        dialogBoxs[0].SetActive(true);
        StartCoroutine(DisableFirstDialog());
    }

    IEnumerator DisableFirstDialog() {
        yield return new WaitForSeconds(5f);
        dialogBoxs[0].SetActive(false);
        yield return new WaitForSeconds(0.5f);
        dialogBoxs[1].SetActive(true);
    }

    public void StoptheBoyClicked() {
        dialogBoxs[1].SetActive(false);
        dialogBoxs[2].SetActive(true);
    }
}
