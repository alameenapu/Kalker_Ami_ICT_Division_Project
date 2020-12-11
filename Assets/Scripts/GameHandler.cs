using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour
{
    public GameObject shadowBridge;
    public GameObject puzzleBridge;
    public GameObject uiText;
    public GameObject chocletUI;
    public GameObject chocletUI1;
    private PlayerMovment pm;
    public Text scoreText;
    int a;
    void Start()
    {
        a = PlayerPrefs.GetInt("Candy_Player");
        scoreText.text = a.ToString();
        pm = FindObjectOfType<PlayerMovment>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ClickOnYesButton() {
        
        shadowBridge.SetActive(true);
        puzzleBridge.SetActive(true);
        uiText.SetActive(false);
    }

    public void CollectChoclet() {
        a = Convert.ToInt32(scoreText.text);
        scoreText.text = (a + 10).ToString();
        chocletUI.SetActive(false);
        PlayerPrefs.SetInt("Candy_Player", a + 10);
        SceneManager.LoadScene("SchoolScene");
    }

    public void CollectChocletFirstScene()
    {
        scoreText.text = (a + 10).ToString();
        chocletUI1.SetActive(false);
        pm.point_2 = true;
    }

    public void CollectChocletSchool()
    {
        a = Convert.ToInt32(scoreText.text);
        scoreText.text = (a + 10).ToString();
        PlayerPrefs.SetInt("Candy_Player", a + 10);
        chocletUI.SetActive(false);
        pm.point_2 = true;
    }

    public void CollectChocletBoard()
    {
        a = Convert.ToInt32(scoreText.text);
        scoreText.text = (a + 50).ToString();
        PlayerPrefs.SetInt("Candy_Player", a + 10);
        chocletUI.SetActive(false);
    }
}
