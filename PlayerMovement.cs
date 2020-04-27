using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //untuk mengkonect antar script
    public CharacterController2D controller;
    float gerakhorizontal = 0f;
    public float velogerak = 40f;
    bool jump = false;
    // Update is called once per frame
    void Update()
    {
        //untuk error checking
        //Debug.Log(Input.GetAxisRaw("Horizontal"));
        gerakhorizontal = Input.GetAxisRaw("Horizontal") * velogerak;
        
        if(Input.GetButtonDown("Jump"))
        {
            jump = true;
        }
    }

    void FixedUpdate()
    {
        //digunakan untuk geraknya player
        //time fixed delta time digunakan untuk kecepatan tetap stabil jika dipanggil berkali2
        controller.Move(gerakhorizontal * Time.fixedDeltaTime, false, jump);
        jump = false;
    }
}
