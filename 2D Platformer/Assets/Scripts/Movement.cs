using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public CharacterController2D controller;                                            //referencing the character controller 2D script to allow the movement setup in the controller to be used here

                                                                                       //public so it can be changed within unity itslef (small box)
                                                                                       //setting variables ...
    public float runSpeed = 10f;
    float horizontalMove = 0f;                                                          //0 for no movement, -1 to move backwards (left) and 1 for forward (right)
    bool jump = false;                                                              



    // Update is called once per frame
    void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;                     //left and right movement

        if (Input.GetButtonDown("Jump"))                                                //jumping input 
        {
            jump = true;
        }


        if (Input.GetButtonDown("Jump")) ;
        {
            jump = true;

        }
    }

    private void FixedUpdate()                                                          //this will force the update to run at the same frequency that the physics system (character controlelr 2d) runs at, making it more accurate than the standard update function
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);            //using the controller, we are moving it on thge horizontal axis at the same, multiplying by the fixed time of the fixedupdate, and allowing for both jumping and crouching
        jump = false;                                                                    //resetting the jump 
    }
}
