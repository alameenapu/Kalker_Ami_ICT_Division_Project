using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum moveState
{
    Set,
    NotSet
}
public class PuzzleMechanism : MonoBehaviour
{
    public GameObject mainShape;
    
    private bool moving;

    private float startPositionX;
    private float endPositionY;
    private Vector3 resetposition;
    public moveState state;
    public bool first = true;

    public CompletingMissionScore cms;

    //private int pieceCount = 0;
    void Start()
    {
        resetposition = this.transform.localPosition;
        cms = FindObjectOfType<CompletingMissionScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if (moving)
        {
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            this.gameObject.transform.localPosition = new Vector3(mousePos.x - startPositionX, mousePos.y - endPositionY, this.gameObject.transform.localPosition.z);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (state == moveState.NotSet) {
                Vector3 mousePos;
                mousePos = Input.mousePosition;
                mousePos = Camera.main.ScreenToWorldPoint(mousePos);

                startPositionX = mousePos.x - this.transform.localPosition.x;
                endPositionY = mousePos.y - this.transform.localPosition.y;

                moving = true;
            }
            
        }
    }

    private void OnMouseUp()
    {
        moving = false;
        if (state == moveState.NotSet) {
            if (Mathf.Abs(this.transform.localPosition.x - mainShape.transform.localPosition.x) <= 0.5f &&
                        Mathf.Abs(this.transform.localPosition.y - mainShape.transform.localPosition.y) <= 0.5f)
            {
                this.transform.localPosition = new Vector3(mainShape.transform.localPosition.x, mainShape.transform.localPosition.y, mainShape.transform.localPosition.z);
                state = moveState.Set;
                if (first)
                {
                    cms.CollectPices(1);
                }
                else {
                    cms.CollectPicesBoard(1);
                }
            }
        }
        

    }
}
