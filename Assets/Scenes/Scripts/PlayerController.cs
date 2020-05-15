using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int moveSpeed;
    //public Rigidbody Player_Cosmos_RB;
    public int jumpForce;
    public CharacterController controller;
    private Vector3 moveDirection;
    public float gravityScale;
    
    public float maxHealth = 100;
    public float currentHealth;
    public HealthBar healthBar;

    public float maxHygiene = 100;
    public float currentHygiene;
    public HygieneBar hygieneBar;

    public float maxKarma = 100;
    public float currentKarma;
    public KarmaBar karmaBar;

    //public int maxHygiene;
    //public int currentHygiene;
    
    
    //public int maxKarma;
    //public int currentKarma;

    // Start is called before the first frame update
    void Start()
    {
        //currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        hygieneBar.SetMaxHygiene(maxHygiene);
        karmaBar.SetMaxKarma(maxKarma);
        
        //healthBar.SetHealth(50);
       // currentHygiene = 0;

        
        //currentKarma = 50;
        //Player_Cosmos_RB = GetComponent<Rigidbody>();
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        //this connects to HealthBar Get Current Health Method
        currentHealth = healthBar.GetCurrentHealth();
        currentHygiene = hygieneBar.GetCurrentHygiene();
        currentKarma = karmaBar.GetCurrentKarma();
        
        //transform.position.z = 0.0f;
        //This is to begin the damage on collision, it doesnt work yet
        
       // void TakeDamage(int damage)
       // {
       //     currentHealth -= damage;
       //     healthBar.SetHealth(currentHealth);
       //     
       // }





        /*Player_Cosmos_RB.velocity = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, Player_Cosmos_RB.velocity.y, Player_Cosmos_RB.velocity.z);

         if (Input.GetButtonDown("Jump"))
         {
             Player_Cosmos_RB.velocity = new Vector3(Player_Cosmos_RB.velocity.x, jumpForce, Player_Cosmos_RB.velocity.z);
         }
         */
        if (!Input.GetKey(KeyCode.LeftShift))
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal") * moveSpeed, moveDirection.y, 0f);

            if (controller.isGrounded)
            {
                if (Input.GetButtonDown("Jump"))
                {
                    moveDirection.y = jumpForce;
                }
            }

            moveDirection.y = moveDirection.y + (Physics.gravity.y * gravityScale);
            controller.Move(moveDirection * Time.deltaTime);
        }
            //controller.Move(moveDirection * Time.deltaTime);
          
    }
    void OnTriggerEnter(Collider collision)
    {
        
        GameObject collidedWith = collision.gameObject;
        Debug.Log("touching: " + collidedWith.name);
        if (collidedWith.tag == "Projectile")
        {
            //TakeDamage(10);
            healthBar.Take_Damage(10);
            Destroy(collidedWith);
            Debug.Log("Touched the projectile");
            
        }
        GameObject collidedWithH = collision.gameObject;
        Debug.Log("touching: " + collidedWithH.name);
        if (collidedWithH.tag == "Needle")
        {
            //TakeDamage(10);
            healthBar.Take_Damage(10);
            hygieneBar.Take_Damage_H(10);
            Destroy(collidedWithH);
            Debug.Log("Touched the needle");

        }
        GameObject collidedWithK = collision.gameObject;
        Debug.Log("touching: " + collidedWithK.name);
        if (collidedWithK.tag == "KarmaCube")
        {
            //TakeDamage(10);
           // healthBar.Take_Damage(10);
            karmaBar.FullKarma(100);
            Destroy(collidedWithK);
            Debug.Log("Touched the KarmaCube");

        }
    }
   

}
