using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovementwithButton : MonoBehaviour
{
    private Rigidbody2D rb;
    private float dirX;
    public float moveSpeed = 10f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
    }

    // Update is called once per frame
    void Update()
    {

        dirX = CrossPlatformInputManager.GetAxis("Horizontal");
        Debug.Log(dirX);
        rb.velocity= new Vector2(dirX, 0f);
    }
}
