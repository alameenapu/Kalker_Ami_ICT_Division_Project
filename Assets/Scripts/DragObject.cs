using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    public GameObject mainShape;
    public GameObject congratsUI;

    private bool moving;

    private float startPositionX;
    private float endPositionY;
    private Vector3 resetposition;
    void Start()
    {
        resetposition = this.transform.localPosition;
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
            Vector3 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            startPositionX = mousePos.x - this.transform.localPosition.x;
            endPositionY = mousePos.y - this.transform.localPosition.y;

            moving = true;

        }
    }

    private void OnMouseUp()
    {
        moving = false;
        if (Mathf.Abs(this.transform.localPosition.x - mainShape.transform.localPosition.x) <= 0.5f &&
                        Mathf.Abs(this.transform.localPosition.y - mainShape.transform.localPosition.y) <= 0.5f)
        {
            this.transform.localPosition = new Vector3(10.25f, 2.2f, 0);
            //this.gameObject.SetActive(false);
            congratsUI.SetActive(true);
        }
        else{
            this.transform.localPosition = new Vector3(resetposition.x, resetposition.y, resetposition.z);
        }

    }
}
