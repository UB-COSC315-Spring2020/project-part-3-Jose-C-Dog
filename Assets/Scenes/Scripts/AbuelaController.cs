using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AbuelaController : MonoBehaviour
{
    public GameObject chankleta;
    public int moveSpeed;
    //public Rigidbody Player_Cosmos_RB;
 
    public CharacterController controller;
    private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        //Player_Cosmos_RB = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
       
        //transform.position.z = 0.0f;
        /*Player_Cosmos_RB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, Player_Cosmos_RB.velocity.y, Player_Cosmos_RB.velocity.z);

         if (Input.GetButtonDown("Jump"))
         {
             Player_Cosmos_RB.velocity = new Vector3(Player_Cosmos_RB.velocity.x, jumpForce, Player_Cosmos_RB.velocity.z);
         }
         */
        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, Input.GetAxis("Vertical") * moveSpeed, 0f);
            controller.Move(moveDirection * Time.deltaTime);
            
            if (Input.GetMouseButtonDown(0))
            {
                GameObject clone;
                clone = Instantiate(chankleta, new Vector3
                (transform.position.x, transform.position.y + 1,
                transform.position.z), transform.rotation) as GameObject;
            }
        }
        //controller.Move(moveDirection * Time.deltaTime);
        //the following if statement is to try to keep Abuela in range of RangeCenter
        /*if (Distance_ > 1.868127)
            {
            Distance_ = 1.868127;
            }
        */
        //controller.Move(moveDirectionA * Time.deltaTime);
    }
}
