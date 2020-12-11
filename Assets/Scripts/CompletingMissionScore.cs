using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CompletingMissionScore : MonoBehaviour
{
    public GameObject chocletUI;
    int pieceCnt = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         
    }
    public void CollectPices(int point) {
        pieceCnt += point;
        if (pieceCnt == 7)
        {
            chocletUI.SetActive(true);
        }
    }

    public void CollectPicesBoard(int point)
    {
        pieceCnt += point;
        if (pieceCnt == 4)
        {
            chocletUI.SetActive(true);
        }
    }
}
