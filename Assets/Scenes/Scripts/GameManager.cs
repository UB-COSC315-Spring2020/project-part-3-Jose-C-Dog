using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject player;
    public Text displayX;
    public Text displayY;
    public Text displayZ;
    public GameObject TopUI;
   

    readonly string playerX = "playerXposition";
    readonly string playerY = "playerYposition";
    readonly string playerZ = "playerZposition";
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        Update_XYZ();
        ToggleCanvas();


    }
    public void Save()
        {
        float xPosition = player.transform.position.x;
        float yPosition = player.transform.position.y;
        float zPosition = player.transform.position.z;

        PlayerPrefs.SetFloat(playerX, xPosition);
        PlayerPrefs.SetFloat(playerY, yPosition);
        PlayerPrefs.SetFloat(playerZ, zPosition);

        Debug.Log("Player Prefs Saved: X =" + xPosition + "Y = "  + yPosition + "Z = " + zPosition );
    }
    public void Load()
        {
        float load_x = PlayerPrefs.GetFloat(playerX);
        float load_y = PlayerPrefs.GetFloat(playerY);
        float load_z = PlayerPrefs.GetFloat(playerZ);

     
        Vector3 loadPlayer = new Vector3(load_x, load_y, load_z);
      //SPECIAL NOTE: LOAD DOES NOT FUNCTION BECAUSE BUILT IN ASSEMBLY PLAYERCONTROLLER
      //IS OVERRIDING TRANSFORM.POSITION ORDERS, I MUST TURN IT OFF BEFORE LOAD ORDER
      //AND SHUT ON AFTER, HOWEVER IT IS ON THE PLAYER_COSMOS OBJECT, NOT SURE HOW

        player.transform.position = loadPlayer;
        Debug.Log("Player Prefs Loaded");
        }
    void ToggleCanvas()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (!TopUI.activeSelf)
            {
                TopUI.SetActive(true);
            }
            else
            {
                TopUI.SetActive(false);
            }
        }


    }


    void Update_XYZ()
    {
        {
            string xText = player.transform.position.x.ToString();
            string yText = player.transform.position.y.ToString();
            string zText = player.transform.position.z.ToString();
            displayX.text = "X: " + xText;
            displayY.text = "Y: " + yText;
            displayZ.text = "Z: " + zText;
        }
    }
}
