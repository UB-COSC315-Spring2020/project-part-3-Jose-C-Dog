using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chankleta_Normal : MonoBehaviour
{
    bool go;//Will Be Used To Change Direction Of Weapon

    GameObject player;//Reference To The Main Character
    GameObject chankleta;//Reference To The Main Character's Weapon

    Transform itemToRotate;//The Weapon That Is A Child Of The Empty Game Object

    Vector3 locationInFrontOfPlayer;//Location In Front Of Player To Travel To


    // Use this for initialization
    void Start()
    {
        go = false; //Set To Not Return Yet

        player = GameObject.Find("Abuela");// The GameObject To Return To
        chankleta = GameObject.Find("Chankleta");//The Weapon The Character Is Holding In The Scene

        //chankleta.GetComponent<MeshRenderer>().enabled = false; //Turn Off The Mesh Render To Make The Weapon Invisible

        itemToRotate = gameObject.transform.GetChild(0); //Find The Weapon That Is The Child Of The Empty Object      

        //Adjust The Location Of The Player Accordingly, Here I Add To The Y position So That The Object Doesn't Go Too Low ...Also Pick A Location In Front Of The Player
        locationInFrontOfPlayer = new Vector3(player.transform.position.x + 1,
        player.transform.position.y + 1, player.transform.position.z)
        + player.transform.forward * 10f;

        StartCoroutine(Boom());//Now Start The Coroutine
    }

    IEnumerator Boom()
    {
        go = true;
        yield return new WaitForSeconds(1.5f);//Any Amount Of Time You Want
        go = false;
    }


    // Update is called once per frame
    void Update()
    {
        itemToRotate.transform.Rotate(0, Time.deltaTime * 500, 0); //Rotate The Object

        if (go)
        {
            transform.position = Vector3.MoveTowards(transform.position,
            locationInFrontOfPlayer, Time.deltaTime * 40); //Change The Position To The Location In Front Of The Player           
        }

        if (!go)
        {
            transform.position = Vector3.MoveTowards(transform.position, 
            new Vector3(player.transform.position.x, player.transform.position.y + 1,
            player.transform.position.z), Time.deltaTime * 40); //Return To Player
        }

        if (!go && Vector3.Distance(player.transform.position, transform.position) < 1.5)
        {
            //Once It Is Close To The Player, Make The Player's Normal Weapon Visible, and Destroy The Clone
           // chankleta.GetComponent<MeshRenderer>().enabled = true;
            Destroy(this.gameObject);
        
        }
    }
}
/*1
2
3
4
5
6
7
8
9
10
11
12
13
14
15
16
17
18
19
20
21
22
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class AkaneExample : MonoBehaviour
{

    public GameObject chankleta;

    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject clone;
            clone = Instantiate(chankleta, new Vector3(transform.position.x, transform.position.y + 1, transform.position.z), transform.rotation) as GameObject;
        }
    }
}
*/