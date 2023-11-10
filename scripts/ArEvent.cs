using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArEvent : MonoBehaviour
{
    bool flip;
    public float speed;
    void Start()
    {
        flip = false;
        speed = 30;
    }

    void Update()
    {
        if (flip) transform.Rotate(0f,0f,0.01f * speed, Space.World);
    }

    public void Flip() {
        flip = true;
    }

    public void NoFlip() {
        flip = false;
    }
}
