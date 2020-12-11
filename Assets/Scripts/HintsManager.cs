using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HintsManager : MonoBehaviour
{
    public GameObject[] sprites;
    public GameObject[] shadowSprites;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UseHints() {
        for (int i = 0; i < sprites.Length; i++) {
            if (sprites[i].GetComponent<PuzzleMechanism>().state == moveState.NotSet) {
                sprites[i].transform.localPosition = new Vector3(shadowSprites[i].transform.localPosition.x, shadowSprites[i].transform.localPosition.y, shadowSprites[i].transform.localPosition.z);
                sprites[i].GetComponent<PuzzleMechanism>().state = moveState.Set;
                if (sprites[i].GetComponent<PuzzleMechanism>().first) {
                    sprites[i].GetComponent<PuzzleMechanism>().cms.CollectPices(1);
                }
                break;
            }
        }
    }
}
