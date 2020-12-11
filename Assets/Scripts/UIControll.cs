using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIControll : MonoBehaviour
{
    public GameObject fUi;
    public GameObject sUi;
    public GameObject tUi;
    public GameObject foUi;
    public GameObject fiUi;
    public GameObject secondPerson;
    public GameObject secondPerson_idle;

    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopUp2ndUI() {
        fUi.SetActive(false);
        sUi.SetActive(true);
    }

    public void PopUp3rdUI()
    {
        sUi.SetActive(false);
        tUi.SetActive(true);
    }

    public void PopUp4rthUI()
    {
        tUi.SetActive(false);
        foUi.SetActive(true);
        secondPerson.SetActive(false);
        secondPerson_idle.SetActive(true);
    }

    public void PopUp5thUI()
    {
        foUi.SetActive(false);
        fiUi.SetActive(true);
    }

    public void PopUpSchoolLast() {
        sUi.SetActive(false);
    }
}
