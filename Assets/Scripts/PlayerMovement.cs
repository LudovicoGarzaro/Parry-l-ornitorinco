using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;
    public Transform cam;

    public float speed = 6f;
    public float time = 2f;

    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;

    public Transform player;
    public Vector3 rotateAmount;
    public bool isStop;

    private void Start()
    {
        isStop = true;
    }

                 

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal, 0f, vertical).normalized;

         

        if (direction.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;           
            controller.Move(moveDir.normalized * speed * Time.deltaTime);

            isStop = false;

            time = 2f;
            
        }
        else
        {
            isStop = true;
            
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {

            Parry();

        }



    }

   


    public void Parry()
    {
        if (isStop == true && time > 0f)
        {
            player.Rotate(rotateAmount * Time.deltaTime);
            time -= Time.deltaTime;
        }


    }

    
}


