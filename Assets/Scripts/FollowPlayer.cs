using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform followObject;
    public Vector3 cammeraOffset;
    public float smoothFactor = 0.5f;
    void Start()
    {
        cammeraOffset = transform.position - followObject.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 newposition = followObject.transform.position + cammeraOffset;
        transform.position = Vector3.Slerp(transform.position, newposition, smoothFactor);
    }
}
