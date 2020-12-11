using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingMenu : MonoBehaviour
{
    public GameObject settingMenuUi;
    public GameObject menuMenuUi;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PopupSetting() {
        settingMenuUi.SetActive(true);
    }

    public void PopDownSetting()
    {
        settingMenuUi.SetActive(false);
    }

    public void PopUpMenu() {
        menuMenuUi.SetActive(true);
    }

    public void PopDownMenu()
    {
        menuMenuUi.SetActive(false);
    }
}
