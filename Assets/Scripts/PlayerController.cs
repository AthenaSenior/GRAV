using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Rigidbody ve SpriteRenderer Tan�mlamas�
    Rigidbody2D rb;
    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        getCompopnents();
    }

    private void getCompopnents()
    {
        //Burada Rigidbody2D ve SpirteRenderer componentlerini ba�layaca��z GetComponent<> ile
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            changeGravity();
            changeSprite();
        }
    }

    private void changeSprite()
    {
        //Burada karakterin sprite �zelli�ini de�i�tece�iz
        //Karakterin ba� a�a�� gitmesi i�in sprite flip y yapmak gerekiyor
    }

    private void changeGravity()
    {
       //Burada rigidbody2d �zerinden gravity scale'� - ile �arpaca��z
    }

}
