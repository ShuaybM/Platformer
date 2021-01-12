using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float runSpeed = 10f;                                                        //public so it can be changed within unity itslef (small box)

    float horizontalMove = 0f;                                                          //setting variables ...
    bool jump = false;



    // Update is called once per frame
    void Update()
    {
        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;                     //left and right movement

        if (Input.GetButtonDown("Jump"))                                                //jumping input 
        {
            jump = true;
        }

    }
}
