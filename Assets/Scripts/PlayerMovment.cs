using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class PlayerMovment : MonoBehaviour
{
    Animator anim;
    public float speed = 0.005f;
    public GameObject uiText;
    public GameObject secondUiText;
    public GameObject target;
    public GameObject target_2;
    int ptag = 0;
    int p2tag = 0;
    public bool point_1 = true;
    public bool point_2 = false;
    public int secondlvl = 0;

    private SampleSceneDialogControll uiController;
    bool walk = false;
    void Start()
    {
        anim = GetComponent<Animator>();
        uiController = GetComponent<SampleSceneDialogControll>();
    }

    // Update is called once per frame
    void Update()
    {
        if (point_1) {
            if (transform.position != target.transform.position)
            {
                if (walk)
                {
                    transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed * Time.deltaTime);
                    anim.SetBool("isWalking", true);

                }
                else {
                    anim.SetBool("isWalking", false);
                }
            }
            if (transform.position == target.transform.position && ptag == 0)
            {
                anim.SetBool("isWalking", false);
                //uiText.gameObject.SetActive(true);
                uiController.ShowFirstDialog();
                point_1 = false;
                ptag = 1;
            }
        }
        if (point_2) {
            if (transform.position != target_2.transform.position)
            {
                if (walk)
                {
                    transform.position = Vector2.MoveTowards(transform.position, target_2.transform.position, speed * Time.deltaTime);
                    anim.SetBool("isWalking", true);
                }
                else {
                    anim.SetBool("isWalking", false);
                }
                    
            }
            if (transform.position == target_2.transform.position && p2tag == 0)
            {

                if (secondlvl == 0)
                {
                    anim.SetBool("isWalking", false);
                    secondUiText.gameObject.SetActive(true);
                    point_2 = false;
                    p2tag = 1;
                }
                else {
                    anim.SetBool("isWalking", false);
                    point_2 = false;
                    p2tag = 1;
                    SceneManager.LoadScene("Blackboard");
                }
            }
        }
        
    }

    public void ClickWalkDown() {
        walk = true;
    }

    public void ClickWalkUp()
    {
        walk = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        
    }


}
